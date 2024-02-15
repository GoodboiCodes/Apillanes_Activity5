<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Label1 = New Label()
        txtFirstnum = New TextBox()
        Label2 = New Label()
        txtSecondnum = New TextBox()
        lblResult = New Label()
        btnDivide = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number: "
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(201, 52)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(115, 23)
        txtFirstnum.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 15)
        Label2.TabIndex = 0
        Label2.Text = "Second Number: "
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(201, 81)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(115, 23)
        txtSecondnum.TabIndex = 2
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        lblResult.Location = New Point(226, 123)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(64, 28)
        lblResult.TabIndex = 2
        lblResult.Text = "Result"
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(46, 122)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(85, 29)
        btnDivide.TabIndex = 3
        btnDivide.Text = "Divide"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(108, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 15)
        Label4.TabIndex = 4
        Label4.Text = "Division Calculator 2.0"
        ' 
        ' Form1
        ' 
        AcceptButton = btnDivide
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(349, 176)
        Controls.Add(Label4)
        Controls.Add(btnDivide)
        Controls.Add(lblResult)
        Controls.Add(txtSecondnum)
        Controls.Add(txtFirstnum)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnDivide As Button
    Friend WithEvents Label4 As Label
End Class
