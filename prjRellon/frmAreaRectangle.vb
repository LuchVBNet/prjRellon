Public Class frmAreaRectangle
    Private decLength, decWidth, decArea As Decimal
    Private Sub frmAreaRectangle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub frmAreaRectangle_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
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
        decLength = 0
        decWidth = 0
        FormatInputs()
        FormatOutputs()
    End Sub

    Private Sub ComputeArea()
        decArea = decLength * decWidth
    End Sub

    Private Sub GetInputs()
        Decimal.TryParse(txtDecimals.Text, frmMain.intDecimals)
        Decimal.TryParse(txtLength.Text, decLength)
        Decimal.TryParse(txtWidth.Text, decWidth)
        ProcessPrecision(frmMain.intDecimals)
        ProcessLW(decLength)
        ProcessLW(decWidth)
        FormatInputs()
    End Sub

    Private Sub ProcessPrecision(ByRef numDecimals As Integer)
        If numDecimals < 0 Then
            MsgBox("Number of decimal places cannot be less than 0.")
            numDecimals = frmMain.intPRECISION
        End If
    End Sub

    Private Sub ProcessLW(ByRef side As Decimal)
        If side < 0 Then
            MsgBox("Length and width cannot be less than 0.")
            side = 0
        End If
    End Sub

    Private Sub input_Changed(sender As Object, e As EventArgs) Handles txtLength.TextChanged, txtWidth.TextChanged
        decArea = 0
        FormatOutputs()
    End Sub

    Private Sub press_Enter(sender As Object, e As KeyPressEventArgs) Handles txtLength.KeyPress, txtWidth.KeyPress, txtDecimals.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnCompute.PerformClick()
        End If
    End Sub

    Private Sub textBox_LoseFocus(sender As Object, e As EventArgs) Handles txtLength.Leave, txtWidth.Leave, txtDecimals.Leave
        GetInputs()
        FormatOutputs()
    End Sub

    Private Sub FormatInputs()
        txtDecimals.Text = frmMain.intDecimals.ToString()
        txtLength.Text = decLength.ToString("N" & frmMain.intDecimals)
        txtWidth.Text = decWidth.ToString("N" & frmMain.intDecimals)
    End Sub

    Private Sub FormatOutputs()
        txtArea.Text = decArea.ToString("N" & frmMain.intDecimals)
    End Sub
End Class