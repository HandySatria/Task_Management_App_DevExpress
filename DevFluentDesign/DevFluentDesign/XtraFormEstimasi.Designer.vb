﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XtraFormEstimasi
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCatatan = New System.Windows.Forms.TextBox()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(16, 375)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(18, 17)
        Me.LabelId.TabIndex = 77
        Me.LabelId.Text = "id"
        Me.LabelId.Visible = False
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(255, 128)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.MaskSettings.Set("mask", "yyyy-MM-dd")
        Me.DateEdit2.Properties.UseMaskAsDisplayFormat = True
        Me.DateEdit2.Size = New System.Drawing.Size(281, 22)
        Me.DateEdit2.TabIndex = 66
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(255, 84)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.MaskSettings.Set("mask", "yyyy-MM-dd")
        Me.DateEdit1.Properties.UseMaskAsDisplayFormat = True
        Me.DateEdit1.Size = New System.Drawing.Size(281, 22)
        Me.DateEdit1.TabIndex = 65
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(312, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 45)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(446, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 45)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(38, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 21)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "CATATAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 21)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "ESTIMASI TGL SELESAI"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(38, 87)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(156, 21)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "ESTIMASI TGL MULAI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(37, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 35)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "DATA ESTIMASI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(227, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 21)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(227, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 21)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(227, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 21)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = ":"
        '
        'TextBoxCatatan
        '
        Me.TextBoxCatatan.Location = New System.Drawing.Point(255, 177)
        Me.TextBoxCatatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxCatatan.Multiline = True
        Me.TextBoxCatatan.Name = "TextBoxCatatan"
        Me.TextBoxCatatan.Size = New System.Drawing.Size(308, 129)
        Me.TextBoxCatatan.TabIndex = 67
        '
        'XtraFormEstimasi
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 437)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.DateEdit2)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCatatan)
        Me.Name = "XtraFormEstimasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XtraForm"
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelId As Label
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCatatan As TextBox
End Class
