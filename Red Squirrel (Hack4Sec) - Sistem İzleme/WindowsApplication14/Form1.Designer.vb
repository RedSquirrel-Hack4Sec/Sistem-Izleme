<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnKlasorSec = New System.Windows.Forms.Button()
        Me.tbKlasor = New System.Windows.Forms.TextBox()
        Me.fbdKlasorSec = New System.Windows.Forms.FolderBrowserDialog()
        Me.fsw1 = New System.IO.FileSystemWatcher()
        Me.lbLog = New System.Windows.Forms.ListBox()
        CType(Me.fsw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKlasorSec
        '
        Me.btnKlasorSec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKlasorSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKlasorSec.Location = New System.Drawing.Point(364, 13)
        Me.btnKlasorSec.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKlasorSec.Name = "btnKlasorSec"
        Me.btnKlasorSec.Size = New System.Drawing.Size(100, 48)
        Me.btnKlasorSec.TabIndex = 0
        Me.btnKlasorSec.Text = "Klasör Seç"
        Me.btnKlasorSec.UseVisualStyleBackColor = True
        '
        'tbKlasor
        '
        Me.tbKlasor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbKlasor.Location = New System.Drawing.Point(13, 26)
        Me.tbKlasor.Margin = New System.Windows.Forms.Padding(4)
        Me.tbKlasor.Name = "tbKlasor"
        Me.tbKlasor.ReadOnly = True
        Me.tbKlasor.Size = New System.Drawing.Size(343, 22)
        Me.tbKlasor.TabIndex = 1
        '
        'fbdKlasorSec
        '
        Me.fbdKlasorSec.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.fbdKlasorSec.ShowNewFolderButton = False
        '
        'fsw1
        '
        Me.fsw1.EnableRaisingEvents = True
        Me.fsw1.IncludeSubdirectories = True
        Me.fsw1.SynchronizingObject = Me
        '
        'lbLog
        '
        Me.lbLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLog.FormattingEnabled = True
        Me.lbLog.ItemHeight = 16
        Me.lbLog.Location = New System.Drawing.Point(0, 69)
        Me.lbLog.Margin = New System.Windows.Forms.Padding(4)
        Me.lbLog.Name = "lbLog"
        Me.lbLog.Size = New System.Drawing.Size(477, 372)
        Me.lbLog.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(477, 441)
        Me.Controls.Add(Me.lbLog)
        Me.Controls.Add(Me.tbKlasor)
        Me.Controls.Add(Me.btnKlasorSec)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Red Squirrel (Hack4Sec) - Sistem İzleme"
        CType(Me.fsw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKlasorSec As System.Windows.Forms.Button
    Friend WithEvents tbKlasor As System.Windows.Forms.TextBox
    Friend WithEvents fbdKlasorSec As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lbLog As System.Windows.Forms.ListBox
    Friend WithEvents fsw1 As System.IO.FileSystemWatcher

End Class
