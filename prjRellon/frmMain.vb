Public Class frmMain
    Public intDecimals As Integer
    Public Const intPRECISION As Integer = 3

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intDecimals = intPRECISION
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        Me.Hide()
        frmPythagorean.Show()
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        Me.Hide()
        frmHeronsFormula.Show()
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        Me.Hide()
        frmAreaCalculator.Show()
    End Sub
End Class