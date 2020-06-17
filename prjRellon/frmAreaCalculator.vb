Public Class frmAreaCalculator

    Private Sub frmAreaCalculator_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub
    Private Sub btnCircle_Click(sender As Object, e As EventArgs) Handles btnCircle.Click
        Me.Hide()
        frmAreaCircle.Show()
    End Sub

    Private Sub frmAreaCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        Me.Hide()
        frmAreaSquare.Show()
    End Sub

    Private Sub btnRectangle_Click(sender As Object, e As EventArgs) Handles btnRectangle.Click
        Me.Hide()
        frmAreaRectangle.Show()
    End Sub

    Private Sub btnTriangle_Click(sender As Object, e As EventArgs) Handles btnTriangle.Click
        Me.Hide()
        frmTriangle.Show()
    End Sub
End Class