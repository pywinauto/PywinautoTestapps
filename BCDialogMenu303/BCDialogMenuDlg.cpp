// BCDialogMenuDlg.cpp : implementation file
//

#include "stdafx.h"
#include "BCDialogMenu.h"
#include "BCDialogMenuDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	//}}AFX_DATA_INIT
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
		// No message handlers
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CBCDialogMenuDlg dialog

CBCDialogMenuDlg::CBCDialogMenuDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CBCDialogMenuDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CBCDialogMenuDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CBCDialogMenuDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CBCDialogMenuDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CBCDialogMenuDlg, CDialog)
	//{{AFX_MSG_MAP(CBCDialogMenuDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_MEASUREITEM()
	ON_WM_MENUCHAR()
	ON_WM_INITMENUPOPUP()
	ON_COMMAND(ID_ZOOM, OnZoom)
	ON_COMMAND(ID_EDIT_CUT, OnEditCut)
	ON_UPDATE_COMMAND_UI(ID_EDIT_CUT, OnUpdateEditCut)
	ON_WM_CLOSE()
	ON_COMMAND(ID_EDIT_COPY, OnEditCopy)
	ON_COMMAND(ID_EDIT_PASTE, OnEditPaste)
	ON_COMMAND(ID_DISABLE, OnDisable)
	ON_COMMAND(ID_ENABLE, OnEnable)
	ON_COMMAND(ID_FILE_CLOSE, OnFileClose)
	ON_COMMAND(ID_FILE_NEW, OnFileNew)
	ON_COMMAND(ID_FILE_OPEN, OnFileOpen)
	ON_COMMAND(ID_FILE_PRINT, OnFilePrint)
	ON_COMMAND(ID_FILE_SAVE, OnFileSave)
	ON_COMMAND(ID_HOMEPAGE, OnHomepage)
	ON_COMMAND(ID_TILE, OnTile)
	ON_COMMAND(ID_WINDOW_CASCADE, OnWindowCascade)
	ON_COMMAND(ID_WINDOW_NEW, OnWindowNew)
	ON_COMMAND(ID_WINDOW_TILE_HORZ, OnWindowTileHorz)
	ON_COMMAND(ID_APP_ABOUT, OnAppAbout)
	ON_COMMAND(ID_APP_EXIT, OnAppExit)
	ON_UPDATE_COMMAND_UI(ID_ZOOM, OnUpdateZoom)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CBCDialogMenuDlg message handlers

BOOL CBCDialogMenuDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	editcheck=TRUE;
	
	FILE *fp=fopen("BCMenu.startup","r");
	if(fp){
		int newstyle;
		if(fscanf(fp,"%d",&newstyle)==1){
			BCMenu::SetMenuDrawMode(newstyle);
		}
		fclose(fp);
	}

	m_menu.LoadMenu(IDR_MYTYPE);
	m_menu.LoadToolbar(IDR_MAINFRAME);
	m_menu.LoadToolbar(IDR_TOOLBAR);
	SetMenu(&m_menu);

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CBCDialogMenuDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CBCDialogMenuDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CBCDialogMenuDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CBCDialogMenuDlg::OnMeasureItem(int nIDCtl, LPMEASUREITEMSTRUCT lpMeasureItemStruct) 
{
	BOOL setflag=FALSE;
	if(lpMeasureItemStruct->CtlType==ODT_MENU){
		if(IsMenu((HMENU)lpMeasureItemStruct->itemID)&&BCMenu::IsMenu((HMENU)lpMeasureItemStruct->itemID)){
			m_menu.MeasureItem(lpMeasureItemStruct);
			setflag=TRUE;
		}
	}
	if(!setflag)CDialog::OnMeasureItem(nIDCtl, lpMeasureItemStruct);
}

LRESULT CBCDialogMenuDlg::OnMenuChar(UINT nChar, UINT nFlags, CMenu* pMenu) 
{
	LRESULT lresult;
	if(BCMenu::IsMenu(pMenu))
		lresult=BCMenu::FindKeyboardShortcut(nChar, nFlags, pMenu);
	else
		lresult=CDialog::OnMenuChar(nChar, nFlags, pMenu);
	return(lresult);
}

void CBCDialogMenuDlg::OnInitMenuPopup(CMenu* pPopupMenu, UINT nIndex, BOOL bSysMenu) 
{
	CDialog::OnInitMenuPopup(pPopupMenu, nIndex, bSysMenu);
	OnUpdateFlush(pPopupMenu);
	
	if(!bSysMenu){
		if(BCMenu::IsMenu(pPopupMenu)) BCMenu::UpdateMenu(pPopupMenu);
	}
	
}

void CBCDialogMenuDlg::OnZoom() 
{
	int newstyle;
	int style=BCMenu::GetMenuDrawMode();
	if(style==BCMENU_DRAWMODE_ORIGINAL)newstyle=BCMENU_DRAWMODE_XP;
	else newstyle=BCMENU_DRAWMODE_ORIGINAL;
	FILE *fp=fopen("BCMenu.startup","w");
	if(fp){
		fprintf(fp,"%d",newstyle);
		fclose(fp);
		MessageBox(_T("You must restart this application\nto see the different menu style"));
	}
}

void CBCDialogMenuDlg::OnEditCut() 
{
	editcheck=!editcheck;
	
}

void CBCDialogMenuDlg::OnUpdateEditCut(CCmdUI* pCmdUI) 
{
	pCmdUI->SetCheck(editcheck);
}

void CBCDialogMenuDlg::OnClose() 
{
	m_menu.DestroyMenu();	
	CDialog::OnClose();
}


void CBCDialogMenuDlg::OnUpdateFlush(CMenu *pMenu)
{
	ASSERT(pMenu != NULL);
	// check the enabled state of various menu items

	CCmdUI state;
	state.m_pMenu = pMenu;
	ASSERT(state.m_pOther == NULL);
	ASSERT(state.m_pParentMenu == NULL);

	// determine if menu is popup in top-level menu and set m_pOther to
	//  it if so (m_pParentMenu == NULL indicates that it is secondary popup)
	HMENU hParentMenu;
	if (AfxGetThreadState()->m_hTrackingMenu == pMenu->m_hMenu)
		state.m_pParentMenu = pMenu;    // parent == child for tracking popup
	else if ((hParentMenu = ::GetMenu(m_hWnd)) != NULL)
	{
		CWnd* pParent = GetTopLevelParent();
			// child windows don't have menus -- need to go to the top!
		if (pParent != NULL &&
			(hParentMenu = ::GetMenu(pParent->m_hWnd)) != NULL)
		{
			int nIndexMax = ::GetMenuItemCount(hParentMenu);
			for (int nIndex = 0; nIndex < nIndexMax; nIndex++)
			{
				if (::GetSubMenu(hParentMenu, nIndex) == pMenu->m_hMenu)
				{
					// when popup is found, m_pParentMenu is containing menu
					state.m_pParentMenu = CMenu::FromHandle(hParentMenu);
					break;
				}
			}
		}
	}

	state.m_nIndexMax = pMenu->GetMenuItemCount();
	for (state.m_nIndex = 0; state.m_nIndex < state.m_nIndexMax;
	  state.m_nIndex++)
	{
		state.m_nID = pMenu->GetMenuItemID(state.m_nIndex);
		if (state.m_nID == 0)
			continue; // menu separator or invalid cmd - ignore it

		ASSERT(state.m_pOther == NULL);
		ASSERT(state.m_pMenu != NULL);
		if (state.m_nID == (UINT)-1)
		{
			// possibly a popup menu, route to first item of that popup
			state.m_pSubMenu = pMenu->GetSubMenu(state.m_nIndex);
			if (state.m_pSubMenu == NULL ||
				(state.m_nID = state.m_pSubMenu->GetMenuItemID(0)) == 0 ||
				state.m_nID == (UINT)-1)
			{
				continue;       // first item of popup can't be routed to
			}
			state.DoUpdate(this, FALSE);    // popups are never auto disabled
		}
		else
		{
			// normal menu item
			// Auto enable/disable if frame window has 'm_bAutoMenuEnable'
			//    set and command is _not_ a system command.
			state.m_pSubMenu = NULL;
			state.DoUpdate(this, state.m_nID < 0xF000);
		}

		// adjust for menu deletions and additions
		UINT nCount = pMenu->GetMenuItemCount();
		if (nCount < state.m_nIndexMax)
		{
			state.m_nIndex -= (state.m_nIndexMax - nCount);
			while (state.m_nIndex < nCount &&
				pMenu->GetMenuItemID(state.m_nIndex) == state.m_nID)
			{
				state.m_nIndex++;
			}
		}
		state.m_nIndexMax = nCount;
	}
}

void CBCDialogMenuDlg::OnEditCopy() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnEditPaste() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnDisable() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnEnable() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnFileClose() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnFileNew() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnFileOpen() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnFilePrint() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnFileSave() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnHomepage() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnTile() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnWindowCascade() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnWindowNew() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnWindowTileHorz() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnAppAbout() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnAppExit() 
{
	// TODO: Add your command handler code here
	
}

void CBCDialogMenuDlg::OnUpdateZoom(CCmdUI* pCmdUI) 
{
	if(BCMenu::GetMenuDrawMode()==BCMENU_DRAWMODE_XP)
		pCmdUI->SetText(_T("Change to Original Menu Style"));
	else 
		pCmdUI->SetText(_T("Change to XP Luna Menu Style"));
}
