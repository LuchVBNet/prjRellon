Public Class frmHeronsFormula
    Private decA, decB, decC, decS, decArea As Decimal
    Private boolImaginary As Boolean = False

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        decA = 0
        decB = 0
        decC = 0
        boolImaginary = False
        FormatInputs()
        FormatOutputs()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'get input
        GetInputs()
        'compute
        ComputeSemiPerimeter()
        ComputeArea()
        'display output
        FormatOutputs()
    End Sub

    Private Sub ComputeSemiPerimeter()
        decS = (decA + decB + decC) / 2
    End Sub

    Private Sub ComputeArea()
        Dim temp As Decimal = decS * (decS - decA) * (decS - decB) * (decS - decC)
        If temp < 0 Then
            MsgBox("Square root of " & temp.ToString("N" & frmMain.intDecimals) & " returns an imaginary value.")
            boolImaginary = True
            decArea = 0
        Else
            decArea = temp ^ (1 / 2)
            boolImaginary = False
        End If
    End Sub

    Private Sub GetInputs()
        Integer.TryParse(txtDecimals.Text, frmMain.intDecimals)
        Decimal.TryParse(txtA.Text, decA)
        Decimal.TryParse(txtB.Text, decB)
        Decimal.TryParse(txtC.Text, decC)
        ProcessPrecision(frmMain.intDecimals)
        ProcessABC(decA)
        ProcessABC(decB)
        ProcessABC(decC)
        FormatInputs()
    End Sub

    Private Sub ProcessABC(ByRef side As Decimal)
        If side < 0 Then
            MsgBox("Sides A, B, and C cannot be less than 0.")
            side = 0
        End If
    End Sub

    Private Sub ProcessPrecision(ByRef numDecimals As Integer)
        If numDecimals < 0 Then
            MsgBox("Number of decimal places cannot be less than 0.")
            numDecimals = frmMain.intPRECISION
        End If
    End Sub

    Private Sub textBox_LoseFocus(sender As Object, e As EventArgs) Handles txtDecimals.Leave, txtC.Leave, txtB.Leave, txtA.Leave
        GetInputs()
        FormatOutputs()
    End Sub

    Private Sub frmHeronsFormula_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub

    Private Sub press_Enter(sender As Object, e As KeyPressEventArgs) Handles txtDecimals.KeyPress, txtC.KeyPress, txtB.KeyPress, txtA.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnCompute.PerformClick()
        End If
    End Sub

    Private Sub input_Changed(sender As Object, e As EventArgs) Handles txtC.TextChanged, txtB.TextChanged, txtA.TextChanged
        decS = 0
        decArea = 0
        FormatOutputs()
    End Sub

    Private Sub FormatInputs()
        txtDecimals.Text = frmMain.intDecimals.ToString()
        txtA.Text = decA.ToString("N" & frmMain.intDecimals)
        txtB.Text = decB.ToString("N" & frmMain.intDecimals)
        txtC.Text = decC.ToString("N" & frmMain.intDecimals)
    End Sub

    Private Sub FormatOutputs()
        txtSemiPerimeter.Text = decS.ToString("N" & frmMain.intDecimals)
        txtArea.Text = If(boolImaginary, "Error", decArea.ToString("N" & frmMain.intDecimals))
    End Sub
End Class