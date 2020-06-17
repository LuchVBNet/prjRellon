<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreaCircle
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picApp = New System.Windows.Forms.PictureBox()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.txtDecimals = New System.Windows.Forms.TextBox()
        Me.lblPi = New System.Windows.Forms.Label()
        Me.txtPi = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblFormula = New System.Windows.Forms.Label()
        CType(Me.picApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInput.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'picApp
        '
        Me.picApp.Image = Global.prjRellon.My.Resources.Resources.circle
        Me.picApp.Location = New System.Drawing.Point(77, 14)
        Me.picApp.Name = "picApp"
        Me.picApp.Size = New System.Drawing.Size(100, 100)
        Me.picApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picApp.TabIndex = 0
        Me.picApp.TabStop = False
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(183, 53)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(225, 34)
        Me.lblAppName.TabIndex = 8
        Me.lblAppName.Text = "Area of a Circle"
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.lblRadius)
        Me.grpInput.Controls.Add(Me.txtRadius)
        Me.grpInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpInput.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInput.Location = New System.Drawing.Point(12, 205)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(460, 100)
        Me.grpInput.TabIndex = 2
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input"
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadius.Location = New System.Drawing.Point(104, 41)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(97, 22)
        Me.lblRadius.TabIndex = 0
        Me.lblRadius.Text = "Radius (r):"
        '
        'txtRadius
        '
        Me.txtRadius.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRadius.Location = New System.Drawing.Point(207, 38)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(150, 29)
        Me.txtRadius.TabIndex = 1
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblArea)
        Me.grpOutput.Controls.Add(Me.txtArea)
        Me.grpOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpOutput.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOutput.Location = New System.Drawing.Point(12, 311)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(460, 100)
        Me.grpOutput.TabIndex = 5
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(130, 36)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(71, 22)
        Me.lblArea.TabIndex = 0
        Me.lblArea.Text = "Area = "
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(207, 33)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(150, 29)
        Me.txtArea.TabIndex = 1
        '
        'lblDecimals
        '
        Me.lblDecimals.AutoSize = True
        Me.lblDecimals.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecimals.Location = New System.Drawing.Point(314, 135)
        Me.lblDecimals.Name = "lblDecimals"
        Me.lblDecimals.Size = New System.Drawing.Size(94, 22)
        Me.lblDecimals.TabIndex = 0
        Me.lblDecimals.Text = "Decimals:"
        '
        'txtDecimals
        '
        Me.txtDecimals.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecimals.Location = New System.Drawing.Point(414, 132)
        Me.txtDecimals.Name = "txtDecimals"
        Me.txtDecimals.Size = New System.Drawing.Size(50, 29)
        Me.txtDecimals.TabIndex = 1
        Me.txtDecimals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPi
        '
        Me.lblPi.AutoSize = True
        Me.lblPi.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPi.Location = New System.Drawing.Point(9, 135)
        Me.lblPi.Name = "lblPi"
        Me.lblPi.Size = New System.Drawing.Size(62, 22)
        Me.lblPi.TabIndex = 6
        Me.lblPi.Text = "Pi (π):"
        '
        'txtPi
        '
        Me.txtPi.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPi.Location = New System.Drawing.Point(77, 132)
        Me.txtPi.Name = "txtPi"
        Me.txtPi.ReadOnly = True
        Me.txtPi.Size = New System.Drawing.Size(200, 29)
        Me.txtPi.TabIndex = 7
        Me.txtPi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompute.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(147, 434)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(109, 34)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Coral
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(262, 434)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormula.Location = New System.Drawing.Point(184, 87)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(162, 27)
        Me.lblFormula.TabIndex = 9
        Me.lblFormula.Text = "Area = π * r^2"
        '
        'frmAreaCircle
        '
        Me.ClientSize = New System.Drawing.Size(484, 482)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPi)
        Me.Controls.Add(Me.txtPi)
        Me.Controls.Add(Me.lblDecimals)
        Me.Controls.Add(Me.txtDecimals)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.lblAppName)
        Me.Controls.Add(Me.picApp)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAreaCircle"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area Calculator (Circle)"
        CType(Me.picApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picApp As PictureBox
    Friend WithEvents lblAppName As Label
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents lblDecimals As Label
    Friend WithEvents txtDecimals As TextBox
    Friend WithEvents lblPi As Label
    Friend WithEvents txtPi As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblFormula As Label
    Friend WithEvents lblRadius As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents txtArea As TextBox
End Class
