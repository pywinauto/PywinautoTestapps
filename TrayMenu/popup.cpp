// This is a part of the Microsoft Foundation Classes C++ library.
// Copyright (c) Microsoft Corporation.  All rights reserved.
//
// This source code is only intended as a supplement to the
// Microsoft Foundation Classes Reference and related
// electronic documentation provided with the library.
// See these sources for detailed information regarding the
// Microsoft Foundation Classes product.

#include "stdafx.h"
#include "popup.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

const UINT idFoldersTree = 1;
const UINT idPinBtn = 2;
const int nHorzMargin = 2;

/////////////////////////////////////////////////////////////////////////////
// CPopupWnd

CString CPopupWnd::m_strClassName;

CPopupWnd::CPopupWnd() : m_bNotify(FALSE)
{
}

CPopupWnd::~CPopupWnd()
{
}

BEGIN_MESSAGE_MAP(CPopupWnd, CWnd)
	ON_WM_SIZE()
	ON_WM_PAINT()
	ON_WM_ERASEBKGND()
	ON_WM_CREATE()
	ON_WM_CANCELMODE()
	ON_WM_NCDESTROY()
	ON_WM_ACTIVATE()
	ON_WM_ACTIVATEAPP()
	ON_COMMAND(idPinBtn, OnKeepVisible)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CPopupWnd message handlers

BOOL CPopupWnd::Create(const RECT& rect)
{
	if (m_strClassName.IsEmpty())
	{
		m_strClassName = ::AfxRegisterWndClass(CS_SAVEBITS, ::LoadCursor(NULL, IDC_ARROW),
			(HBRUSH)(COLOR_BTNFACE + 1), NULL);
	}

	return CWnd::CreateEx(
    WS_EX_TOPMOST | WS_EX_DLGMODALFRAME, 
    m_strClassName, 
    _T("Popup"), 
    WS_POPUP | WS_VISIBLE | WS_BORDER, 
    rect, 
    AfxGetMainWnd(), 
    NULL);
}

void CPopupWnd::OnSize(UINT nType, int cx, int cy)
{
	CWnd::OnSize(nType, cx, cy);
	m_rectCaption = CRect(0, 0, cx, cy);
}

void CPopupWnd::OnPaint()
{
	CPaintDC dc(this); // device context for painting

	dc.FillRect(m_rectCaption, &afxGlobalData.brBarFace);

	int nOldBkMode = dc.SetBkMode(TRANSPARENT);
	COLORREF clrOldText = dc.SetTextColor(afxGlobalData.clrBarText);
	CFont* pOldFont = (CFont*) dc.SelectObject(&afxGlobalData.fontRegular);

	CRect rectText = m_rectCaption;
	rectText.left += 2 * nHorzMargin;
	rectText.right -= 2 * nHorzMargin;

	dc.DrawText(m_strCaption, rectText, DT_END_ELLIPSIS | DT_SINGLELINE | DT_VCENTER);

	dc.SelectObject(pOldFont);
	dc.SetTextColor(clrOldText);
	dc.SetBkMode(nOldBkMode);
}

BOOL CPopupWnd::OnEraseBkgnd(CDC* /*pDC*/)
{
	return TRUE;
}

BOOL CPopupWnd::PreTranslateMessage(MSG* pMsg)
{
	switch (pMsg->message)
	{
	case WM_KEYDOWN:
		if (pMsg->wParam == VK_ESCAPE)
		{
			CloseMe();
			return TRUE;
		}
		break;
	}

	return CWnd::PreTranslateMessage(pMsg);
}

int CPopupWnd::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CWnd::OnCreate(lpCreateStruct) == -1)
		return -1;

	CRect rect;
	rect.SetRectEmpty();

  m_strCaption = _T("About popup");

	m_bNotify = TRUE;

	return 0;
}

void CPopupWnd::OnCancelMode()
{
	CWnd::OnCancelMode();
	CloseMe();
}

void CPopupWnd::OnNcDestroy()
{
	CWnd::OnNcDestroy();
	delete this;
}

void CPopupWnd::OnActivateApp(BOOL bActive, DWORD dwThreadID)
{
	CWnd::OnActivateApp(bActive, dwThreadID);

	if (!bActive)
	{
		CloseMe();
	}
}

void CPopupWnd::OnActivate(UINT nState, CWnd* pWndOther, BOOL bMinimized)
{
	CWnd::OnActivate(nState, pWndOther, bMinimized);

	if (nState == WA_INACTIVE)
	{
		CloseMe();
	}
}

void CPopupWnd::CloseMe()
{
	PostMessage(WM_CLOSE);
}

void CPopupWnd::OnKeepVisible()
{
	CloseMe();
}

