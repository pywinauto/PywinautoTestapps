// This is a part of the Microsoft Foundation Classes C++ library.
// Copyright (c) Microsoft Corporation.  All rights reserved.
//
// This source code is only intended as a supplement to the
// Microsoft Foundation Classes Reference and related
// electronic documentation provided with the library.
// See these sources for detailed information regarding the
// Microsoft Foundation Classes product.

#pragma once
#include "stdafx.h"

/////////////////////////////////////////////////////////////////////////////
// CPopupWnd window

class CPopupWnd : public CWnd
{
// Construction
public:
	CPopupWnd();

// Attributes
protected:
	static CString m_strClassName;
	

	CRect m_rectCaption;
	CString m_strCaption;

	BOOL m_bNotify;

// Operations
public:
	void CloseMe();

// Overrides
public:
	virtual BOOL Create(const RECT& rect);
	virtual BOOL PreTranslateMessage(MSG* pMsg);

// Implementation
public:
	virtual ~CPopupWnd();

protected:
	afx_msg void OnSize(UINT nType, int cx, int cy);
	afx_msg void OnPaint();
	afx_msg BOOL OnEraseBkgnd(CDC* pDC);
	afx_msg int OnCreate(LPCREATESTRUCT lpCreateStruct);
	afx_msg void OnCancelMode();
	afx_msg void OnNcDestroy();
	afx_msg void OnActivate(UINT nState, CWnd* pWndOther, BOOL bMinimized);
	afx_msg void OnActivateApp(BOOL bActive, DWORD dwThreadID);
	afx_msg void OnKeepVisible();

	DECLARE_MESSAGE_MAP()
};

