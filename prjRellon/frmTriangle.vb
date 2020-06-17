Public Class frmTriangle
    Private decBase, decHeight, decArea As Decimal
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
        decBase = 0
        decHeight = 0
        FormatInputs()
        FormatOutputs()
    End Sub

    Private Sub ComputeArea()
        decArea = decBase * decHeight / 2
    End Sub

    Private Sub GetInputs()
        Decimal.TryParse(txtDecimals.Text, frmMain.intDecimals)
        Decimal.TryParse(txtBase.Text, decBase)
        Decimal.TryParse(txtHeight.Text, decHeight)
        ProcessPrecision(frmMain.intDecimals)
        ProcessLW(decBase)
        ProcessLW(decHeight)
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
            MsgBox("Base and height cannot be less than 0.")
            side = 0
        End If
    End Sub

    Private Sub input_Changed(sender As Object, e As EventArgs) Handles txtBase.TextChanged, txtHeight.TextChanged
        decArea = 0
        FormatOutputs()
    End Sub

    Private Sub press_Enter(sender As Object, e As KeyPressEventArgs) Handles txtBase.KeyPress, txtHeight.KeyPress, txtDecimals.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnCompute.PerformClick()
        End If
    End Sub

    Private Sub textBox_LoseFocus(sender As Object, e As EventArgs) Handles txtBase.Leave, txtHeight.Leave, txtDecimals.Leave
        GetInputs()
        FormatOutputs()
    End Sub

    Private Sub FormatInputs()
        txtDecimals.Text = frmMain.intDecimals.ToString()
        txtBase.Text = decBase.ToString("N" & frmMain.intDecimals)
        txtHeight.Text = decHeight.ToString("N" & frmMain.intDecimals)
    End Sub

    Private Sub FormatOutputs()
        txtArea.Text = decArea.ToString("N" & frmMain.intDecimals)
    End Sub
End Class