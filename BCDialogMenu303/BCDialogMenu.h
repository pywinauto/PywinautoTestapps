// BCDialogMenu.h : main header file for the BCDIALOGMENU application
//

#if !defined(AFX_BCDIALOGMENU_H__56630FDB_AF11_4BA2_888C_ECDD7FE40CDB__INCLUDED_)
#define AFX_BCDIALOGMENU_H__56630FDB_AF11_4BA2_888C_ECDD7FE40CDB__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CBCDialogMenuApp:
// See BCDialogMenu.cpp for the implementation of this class
//

class CBCDialogMenuApp : public CWinApp
{
public:
	CBCDialogMenuApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CBCDialogMenuApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CBCDialogMenuApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_BCDIALOGMENU_H__56630FDB_AF11_4BA2_888C_ECDD7FE40CDB__INCLUDED_)
