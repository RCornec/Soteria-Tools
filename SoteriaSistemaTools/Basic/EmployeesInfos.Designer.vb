<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeesInfos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tab = New System.Windows.Forms.TabControl()
        Me.tabinfos = New System.Windows.Forms.TabPage()
        Me.tabclasses = New System.Windows.Forms.TabPage()
        Me.tablogin = New System.Windows.Forms.TabPage()
        Me.tabhistory = New System.Windows.Forms.TabPage()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(198, 416)
        Me.DataGridView1.TabIndex = 2
        '
        'tab
        '
        Me.tab.Controls.Add(Me.tabinfos)
        Me.tab.Controls.Add(Me.tabclasses)
        Me.tab.Controls.Add(Me.tablogin)
        Me.tab.Controls.Add(Me.tabhistory)
        Me.tab.Location = New System.Drawing.Point(229, 13)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(564, 445)
        Me.tab.TabIndex = 3
        '
        'tabinfos
        '
        Me.tabinfos.Location = New System.Drawing.Point(4, 22)
        Me.tabinfos.Name = "tabinfos"
        Me.tabinfos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabinfos.Size = New System.Drawing.Size(556, 419)
        Me.tabinfos.TabIndex = 0
        Me.tabinfos.Text = "Information"
        Me.tabinfos.UseVisualStyleBackColor = True
        '
        'tabclasses
        '
        Me.tabclasses.Location = New System.Drawing.Point(4, 22)
        Me.tabclasses.Name = "tabclasses"
        Me.tabclasses.Padding = New System.Windows.Forms.Padding(3)
        Me.tabclasses.Size = New System.Drawing.Size(556, 419)
        Me.tabclasses.TabIndex = 1
        Me.tabclasses.Text = "Classes"
        Me.tabclasses.UseVisualStyleBackColor = True
        '
        'tablogin
        '
        Me.tablogin.Location = New System.Drawing.Point(4, 22)
        Me.tablogin.Name = "tablogin"
        Me.tablogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tablogin.Size = New System.Drawing.Size(556, 419)
        Me.tablogin.TabIndex = 2
        Me.tablogin.Text = "History"
        Me.tablogin.UseVisualStyleBackColor = True
        '
        'tabhistory
        '
        Me.tabhistory.Location = New System.Drawing.Point(4, 22)
        Me.tabhistory.Name = "tabhistory"
        Me.tabhistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabhistory.Size = New System.Drawing.Size(556, 419)
        Me.tabhistory.TabIndex = 3
        Me.tabhistory.Text = "Login"
        Me.tabhistory.UseVisualStyleBackColor = True
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 470)
        Me.Controls.Add(Me.tab)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Employees"
        Me.Text = "Employees"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tab As System.Windows.Forms.TabControl
    Friend WithEvents tabinfos As System.Windows.Forms.TabPage
    Friend WithEvents tabclasses As System.Windows.Forms.TabPage
    Friend WithEvents tablogin As System.Windows.Forms.TabPage
    Friend WithEvents tabhistory As System.Windows.Forms.TabPage
End Class
