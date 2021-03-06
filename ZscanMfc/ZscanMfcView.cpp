
// ZscanMfcView.cpp : implementation of the CZscanMfcView class
//

#include "stdafx.h"
// SHARED_HANDLERS can be defined in an ATL project implementing preview, thumbnail
// and search filter handlers and allows sharing of document code with that project.
#ifndef SHARED_HANDLERS
#include "ZscanMfc.h"
#endif

#include "ZscanMfcDoc.h"
#include "ZscanMfcView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CZscanMfcView

IMPLEMENT_DYNCREATE(CZscanMfcView, CView)

BEGIN_MESSAGE_MAP(CZscanMfcView, CView)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
END_MESSAGE_MAP()

// CZscanMfcView construction/destruction

CZscanMfcView::CZscanMfcView()
{
	// TODO: add construction code here

}

CZscanMfcView::~CZscanMfcView()
{
}

BOOL CZscanMfcView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: Modify the Window class or styles here by modifying
	//  the CREATESTRUCT cs

	return CView::PreCreateWindow(cs);
}

// CZscanMfcView drawing

void CZscanMfcView::OnDraw(CDC* /*pDC*/)
{
	CZscanMfcDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: add draw code for native data here
}

void CZscanMfcView::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	ClientToScreen(&point);
	OnContextMenu(this, point);
}

void CZscanMfcView::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// CZscanMfcView diagnostics

#ifdef _DEBUG
void CZscanMfcView::AssertValid() const
{
	CView::AssertValid();
}

void CZscanMfcView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CZscanMfcDoc* CZscanMfcView::GetDocument() const // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CZscanMfcDoc)));
	return (CZscanMfcDoc*)m_pDocument;
}
#endif //_DEBUG


// CZscanMfcView message handlers
