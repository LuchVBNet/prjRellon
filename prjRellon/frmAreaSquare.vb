Public Class frmAreaSquare
    Private decSide, decArea As Decimal
    Private Sub frmAreaCircle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub frmAreaCircle_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmAreaCalculator.Show()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'get input
        GetInputs()
        'compute
        ComputeArea()
        'display output
        FormatOutputs()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        decSide = 0
        FormatInputs()
        FormatOutputs()
    End Sub

    Private Sub ComputeArea()
        decArea = decSide ^ 2
    End Sub

    Private Sub GetInputs()
        Decimal.TryParse(txtDecimals.Text, frmMain.intDecimals)
        Decimal.TryParse(txtSide.Text, decSide)
        ProcessPrecision(frmMain.intDecimals)
        ProcessRadius(decSide)
        FormatInputs()
    End Sub

    Private Sub ProcessPrecision(ByRef numDecimals As Integer)
        If numDecimals < 0 Then
            MsgBox("Number of decimal places cannot be less than 0.")
            numDecimals = frmMain.intPRECISION
        End If
    End Sub

    Private Sub ProcessRadius(ByRef radius As Decimal)
        If radius < 0 Then
            MsgBox("Radius cannot be less than 0.")
            radius = 0
        End If
    End Sub

    Private Sub input_Changed(sender As Object, e As EventArgs) Handles txtSide.TextChanged
        decArea = 0
        FormatOutputs()
    End Sub

    Private Sub press_Enter(sender As Object, e As KeyPressEventArgs) Handles txtSide.KeyPress, txtDecimals.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnCompute.PerformClick()
        End If
    End Sub

    Private Sub textBox_LoseFocus(sender As Object, e As EventArgs) Handles txtSide.Leave, txtDecimals.Leave
        GetInputs()
        FormatOutputs()
    End Sub

    Private Sub FormatInputs()
        txtDecimals.Text = frmMain.intDecimals.ToString()
        txtSide.Text = decSide.ToString("N" & frmMain.intDecimals)
    End Sub

    Private Sub FormatOutputs()
        txtArea.Text = decArea.ToString("N" & frmMain.intDecimals)
    End Sub
End Class