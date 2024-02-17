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
        Me.ComboPilote = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datee = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nbPassa = New System.Windows.Forms.ComboBox()
        Me.voll = New System.Windows.Forms.ComboBox()
        Me.av = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LabDvg = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboPilote
        '
        Me.ComboPilote.FormattingEnabled = True
        Me.ComboPilote.Location = New System.Drawing.Point(291, 25)
        Me.ComboPilote.Name = "ComboPilote"
        Me.ComboPilote.Size = New System.Drawing.Size(208, 28)
        Me.ComboPilote.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sélectionnez un pilote"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.datee)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.nbPassa)
        Me.GroupBox1.Controls.Add(Me.voll)
        Me.GroupBox1.Controls.Add(Me.av)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 209)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info ffectation vol"
        '
        'datee
        '
        Me.datee.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datee.Location = New System.Drawing.Point(585, 22)
        Me.datee.Name = "datee"
        Me.datee.Size = New System.Drawing.Size(200, 26)
        Me.datee.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Image = Global.GestionJournaux.My.Resources.Resources.close
        Me.Button2.Location = New System.Drawing.Point(533, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 73)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.GestionJournaux.My.Resources.Resources.copy_diskette
        Me.Button1.Location = New System.Drawing.Point(213, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 73)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nbPassa
        '
        Me.nbPassa.FormattingEnabled = True
        Me.nbPassa.Location = New System.Drawing.Point(594, 65)
        Me.nbPassa.Name = "nbPassa"
        Me.nbPassa.Size = New System.Drawing.Size(208, 28)
        Me.nbPassa.TabIndex = 6
        '
        'voll
        '
        Me.voll.FormattingEnabled = True
        Me.voll.Location = New System.Drawing.Point(87, 29)
        Me.voll.Name = "voll"
        Me.voll.Size = New System.Drawing.Size(208, 28)
        Me.voll.TabIndex = 5
        '
        'av
        '
        Me.av.FormattingEnabled = True
        Me.av.Location = New System.Drawing.Point(87, 65)
        Me.av.Name = "av"
        Me.av.Size = New System.Drawing.Size(208, 28)
        Me.av.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(455, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nbre Passagers"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(453, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Avion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Vol"
        '
        'Button3
        '
        Me.Button3.Image = Global.GestionJournaux.My.Resources.Resources.updated
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(696, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 73)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Mettre a jour"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(670, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(218, 54)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Ajouter"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LabDvg
        '
        Me.LabDvg.AutoSize = True
        Me.LabDvg.Location = New System.Drawing.Point(62, 366)
        Me.LabDvg.Name = "LabDvg"
        Me.LabDvg.Size = New System.Drawing.Size(135, 20)
        Me.LabDvg.TabIndex = 11
        Me.LabDvg.Text = "Liste des voyages"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(66, 397)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(822, 150)
        Me.dgv.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 503)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.LabDvg)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboPilote)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboPilote As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents nbPassa As ComboBox
    Friend WithEvents voll As ComboBox
    Friend WithEvents av As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents datee As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents LabDvg As Label
    Friend WithEvents dgv As DataGridView
End Class
