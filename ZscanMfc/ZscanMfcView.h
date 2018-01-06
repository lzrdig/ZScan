
// ZscanMfcView.h : interface of the CZscanMfcView class
//

#pragma once


class CZscanMfcView : public CView
{
protected: // create from serialization only
	CZscanMfcView();
	DECLARE_DYNCREATE(CZscanMfcView)

// Attributes
public:
	CZscanMfcDoc* GetDocument() const;

// Operations
public:

// Overrides
public:
	virtual void OnDraw(CDC* pDC);  // overridden to draw this view
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:

// Implementation
public:
	virtual ~CZscanMfcView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	afx_msg void OnFilePrintPreview();
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnContextMenu(CWnd* pWnd, CPoint point);
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // debug version in ZscanMfcView.cpp
inline CZscanMfcDoc* CZscanMfcView::GetDocument() const
   { return reinterpret_cast<CZscanMfcDoc*>(m_pDocument); }
#endif

