// stdafx.h : include file for standard system include files,
//  or project specific include files that are used frequently, but
//      are changed infrequently
//
// This is a part of the Microsoft Foundation Classes C++ library.
// Copyright (c) Microsoft Corporation.  All rights reserved.
//
// This source code is only intended as a supplement to the
// Microsoft Foundation Classes Reference and related
// electronic documentation provided with the library.
// See these sources for detailed information regarding the
// Microsoft Foundation Classes product.
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

#define VC_EXTRALEAN        // Exclude rarely-used stuff from Windows headers

#include <afxwin.h>         // MFC core and standard components
#include <afxext.h>         // MFC extensions
#include <afxcview.h>
#ifndef _AFX_NO_AFXCMN_SUPPORT
#include <afxcmn.h>         // MFC support for Windows 95 Common Controls
#endif // _AFX_NO_AFXCMN_SUPPORT
