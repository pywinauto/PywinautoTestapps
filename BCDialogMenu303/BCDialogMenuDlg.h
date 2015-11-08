// BCDialogMenuDlg.h : header file
//

#if !defined(AFX_BCDIALOGMENUDLG_H__B535B376_88C5_414F_AAE5_9CACD9C0E3BD__INCLUDED_)
#define AFX_BCDIALOGMENUDLG_H__B535B376_88C5_414F_AAE5_9CACD9C0E3BD__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "BCMenu.h"

/////////////////////////////////////////////////////////////////////////////
// CBCDialogMenuDlg dialog

class CBCDialogMenuDlg : public CDialog
{
// Construction
public:
	CBCDialogMenuDlg(CWnd* pParent = NULL);	// standard constructor
	void OnUpdateFlush(CMenu *pMenu);

// Dialog Data
	//{{AFX_DATA(CBCDialogMenuDlg)
	enum { IDD = IDD_BCDIALOGMENU_DIALOG };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CBCDialogMenuDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;
	BCMenu m_menu;
	BOOL editcheck;
	// Generated message map functions
	//{{AFX_MSG(CBCDialogMenuDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnMeasureItem(int nIDCtl, LPMEASUREITEMSTRUCT lpMeasureItemStruct);
	afx_msg LRESULT OnMenuChar(UINT nChar, UINT nFlags, CMenu* pMenu);
	afx_msg void OnInitMenuPopup(CMenu* pPopupMenu, UINT nIndex, BOOL bSysMenu);
	afx_msg void OnZoom();
	afx_msg void OnEditCut();
	afx_msg void OnUpdateEditCut(CCmdUI* pCmdUI);
	afx_msg void OnClose();
	afx_msg void OnEditCopy();
	afx_msg void OnEditPaste();
	afx_msg void OnDisable();
	afx_msg void OnEnable();
	afx_msg void OnFileClose();
	afx_msg void OnFileNew();
	afx_msg void OnFileOpen();
	afx_msg void OnFilePrint();
	afx_msg void OnFileSave();
	afx_msg void OnHomepage();
	afx_msg void OnTile();
	afx_msg void OnWindowCascade();
	afx_msg void OnWindowNew();
	afx_msg void OnWindowTileHorz();
	afx_msg void OnAppAbout();
	afx_msg void OnAppExit();
	afx_msg void OnUpdateZoom(CCmdUI* pCmdUI);
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_BCDIALOGMENUDLG_H__B535B376_88C5_414F_AAE5_9CACD9C0E3BD__INCLUDED_)
