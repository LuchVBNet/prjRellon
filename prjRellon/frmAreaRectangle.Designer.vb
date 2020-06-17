<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreaRectangle
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
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.txtDecimals = New System.Windows.Forms.TextBox()
        Me.picApp = New System.Windows.Forms.PictureBox()
        Me.grpInput.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        CType(Me.picApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.lblWidth)
        Me.grpInput.Controls.Add(Me.txtWidth)
        Me.grpInput.Controls.Add(Me.lblLength)
        Me.grpInput.Controls.Add(Me.txtLength)
        Me.grpInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpInput.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInput.Location = New System.Drawing.Point(12, 205)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(460, 100)
        Me.grpInput.TabIndex = 2
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidth.Location = New System.Drawing.Point(239, 39)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(94, 22)
        Me.lblWidth.TabIndex = 2
        Me.lblWidth.Text = "Width (w):"
        '
        'txtWidth
        '
        Me.txtWidth.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWidth.Location = New System.Drawing.Point(339, 36)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 29)
        Me.txtWidth.TabIndex = 3
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(22, 39)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(94, 22)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "Length (l):"
        '
        'txtLength
        '
        Me.txtLength.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(122, 36)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 29)
        Me.txtLength.TabIndex = 1
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
        Me.lblArea.Location = New System.Drawing.Point(120, 41)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(71, 22)
        Me.lblArea.TabIndex = 0
        Me.lblArea.Text = "Area = "
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(197, 38)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(150, 29)
        Me.txtArea.TabIndex = 1
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(153, 53)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(284, 34)
        Me.lblAppName.TabIndex = 6
        Me.lblAppName.Text = "Area of a Rectangle"
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormula.Location = New System.Drawing.Point(154, 87)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(112, 27)
        Me.lblFormula.TabIndex = 7
        Me.lblFormula.Text = "Area = lw"
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
        'picApp
        '
        Me.picApp.Image = Global.prjRellon.My.Resources.Resources.rectangle
        Me.picApp.Location = New System.Drawing.Point(47, 14)
        Me.picApp.Name = "picApp"
        Me.picApp.Size = New System.Drawing.Size(100, 100)
        Me.picApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picApp.TabIndex = 35
        Me.picApp.TabStop = False
        '
        'frmAreaRectangle
        '
        Me.ClientSize = New System.Drawing.Size(484, 482)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblDecimals)
        Me.Controls.Add(Me.txtDecimals)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.lblAppName)
        Me.Controls.Add(Me.picApp)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAreaRectangle"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area Calculator (Rectangle)"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        CType(Me.picApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents lblLength As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents lblArea As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents lblAppName As Label
    Friend WithEvents lblFormula As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblDecimals As Label
    Friend WithEvents txtDecimals As TextBox
    Friend WithEvents picApp As PictureBox
    Friend WithEvents lblWidth As Label
    Friend WithEvents txtWidth As TextBox
End Class
