// stdafx.h : include file for standard system include files,
//  or project specific include files that are used frequently, but
//      are changed infrequently
//

#if !defined(AFX_STDAFX_H__5D00AA02_0646_403B_9367_D8616CC3A529__INCLUDED_)
#define AFX_STDAFX_H__5D00AA02_0646_403B_9367_D8616CC3A529__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000


#include <winsdkver.h>

#ifndef _WIN32_WINNT
// Modify the following define to target a prior platform. Refer to MSDN
// for the latest info on corresponding values for different platforms.
#define _WIN32_WINNT _WIN32_WINNT_MAXVER
#endif

#include <sdkddkver.h>

#define VC_EXTRALEAN		// Exclude rarely-used stuff from Windows headers

#include <afxwin.h>         // MFC core and standard components
#include <afxext.h>         // MFC extensions
#include <afxdisp.h>        // MFC Automation classes
#include <afxdtctl.h>		// MFC support for Internet Explorer 4 Common Controls
#ifndef _AFX_NO_AFXCMN_SUPPORT
#include <afxcmn.h>			// MFC support for Windows Common Controls
#endif // _AFX_NO_AFXCMN_SUPPORT


//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_STDAFX_H__5D00AA02_0646_403B_9367_D8616CC3A529__INCLUDED_)
