<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreaCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAreaCalculator))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTriangle = New System.Windows.Forms.Button()
        Me.btnRectangle = New System.Windows.Forms.Button()
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Choose a shape"
        '
        'btnTriangle
        '
        Me.btnTriangle.BackgroundImage = CType(resources.GetObject("btnTriangle.BackgroundImage"), System.Drawing.Image)
        Me.btnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTriangle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTriangle.ForeColor = System.Drawing.Color.White
        Me.btnTriangle.Location = New System.Drawing.Point(400, 330)
        Me.btnTriangle.Name = "btnTriangle"
        Me.btnTriangle.Size = New System.Drawing.Size(200, 200)
        Me.btnTriangle.TabIndex = 3
        Me.btnTriangle.Text = "Triangle"
        Me.btnTriangle.UseVisualStyleBackColor = True
        '
        'btnRectangle
        '
        Me.btnRectangle.BackgroundImage = Global.prjRellon.My.Resources.Resources.rectangle
        Me.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRectangle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRectangle.ForeColor = System.Drawing.Color.White
        Me.btnRectangle.Location = New System.Drawing.Point(84, 330)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(200, 200)
        Me.btnRectangle.TabIndex = 2
        Me.btnRectangle.Text = "Rectangle"
        Me.btnRectangle.UseVisualStyleBackColor = True
        '
        'btnSquare
        '
        Me.btnSquare.BackgroundImage = Global.prjRellon.My.Resources.Resources.square
        Me.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSquare.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare.ForeColor = System.Drawing.Color.White
        Me.btnSquare.Location = New System.Drawing.Point(400, 88)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(200, 200)
        Me.btnSquare.TabIndex = 1
        Me.btnSquare.Text = "Square"
        Me.btnSquare.UseVisualStyleBackColor = True
        '
        'btnCircle
        '
        Me.btnCircle.BackgroundImage = Global.prjRellon.My.Resources.Resources.circle
        Me.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCircle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCircle.ForeColor = System.Drawing.Color.White
        Me.btnCircle.Location = New System.Drawing.Point(84, 88)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(200, 200)
        Me.btnCircle.TabIndex = 0
        Me.btnCircle.Text = "Circle"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'frmAreaCalculator
        '
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTriangle)
        Me.Controls.Add(Me.btnRectangle)
        Me.Controls.Add(Me.btnSquare)
        Me.Controls.Add(Me.btnCircle)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAreaCalculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCircle As Button
    Friend WithEvents btnSquare As Button
    Friend WithEvents btnRectangle As Button
    Friend WithEvents btnTriangle As Button
    Friend WithEvents Label1 As Label
End Class
