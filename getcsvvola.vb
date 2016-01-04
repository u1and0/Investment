Sub getcsvvola()
'
' getcsvvola Macro
'ver1.0
'<Introduction>
'csvで取得してきたボラティリティをexcelファイルにコピペするvba
'<<How to use>>
'Excelで動作
'<<Todo>>
'動作が不安定。csv閉じるときに勝手に終了することがある
'iMacros動かすと同時に動かすことできるんじゃないか


'
    Workbooks.Open Filename:="E:\Users\U1and0\Dropbox\Document\FX\volatility.csv"
'   ---Select 14 rows from last row
    Dim lastrow
    lastrow = Cells(Rows.Count, 1).End(xlUp).Row
    Range(Rows(lastrow), Rows(lastrow - 13)).Select

    Selection.Copy

'   -----------------------------------------------------------------------

'    ---Paste last empry row
    Windows("volatility.xlsm").Activate
    Dim endrow
    endrow = Cells(Rows.Count, "A").End(xlUp).Row + 1
    Range("A" & endrow).Select
'    ---Paste only value
   Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
   :=False, Transpose:=False
   
   
'   ---Clear clipboard & Close window
    Application.CutCopyMode = False
   Workbooks("volatility.csv").Close SaveChanges:=False
End Sub


