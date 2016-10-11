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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tp_input = New System.Windows.Forms.TabPage()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.tb_nis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tp_tampil = New System.Windows.Forms.TabPage()
        Me.dg_view = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.tp_input.SuspendLayout()
        Me.tp_tampil.SuspendLayout()
        CType(Me.dg_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tp_input)
        Me.TabControl1.Controls.Add(Me.tp_tampil)
        Me.TabControl1.Location = New System.Drawing.Point(12, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(494, 238)
        Me.TabControl1.TabIndex = 0
        '
        'tp_input
        '
        Me.tp_input.Controls.Add(Me.btn_delete)
        Me.tp_input.Controls.Add(Me.btn_update)
        Me.tp_input.Controls.Add(Me.btn_edit)
        Me.tp_input.Controls.Add(Me.btn_simpan)
        Me.tp_input.Controls.Add(Me.Label3)
        Me.tp_input.Controls.Add(Me.tb_alamat)
        Me.tp_input.Controls.Add(Me.tb_nama)
        Me.tp_input.Controls.Add(Me.tb_nis)
        Me.tp_input.Controls.Add(Me.Label2)
        Me.tp_input.Controls.Add(Me.Label1)
        Me.tp_input.Location = New System.Drawing.Point(4, 22)
        Me.tp_input.Name = "tp_input"
        Me.tp_input.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_input.Size = New System.Drawing.Size(486, 212)
        Me.tp_input.TabIndex = 0
        Me.tp_input.Text = "Input"
        Me.tp_input.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_delete.Location = New System.Drawing.Point(128, 117)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(118, 23)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_update.Location = New System.Drawing.Point(9, 117)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(113, 23)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_edit.Location = New System.Drawing.Point(128, 89)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(118, 23)
        Me.btn_edit.TabIndex = 7
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_simpan.Location = New System.Drawing.Point(9, 89)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(113, 23)
        Me.btn_simpan.TabIndex = 6
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Alamat"
        '
        'tb_alamat
        '
        Me.tb_alamat.Location = New System.Drawing.Point(80, 58)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(166, 20)
        Me.tb_alamat.TabIndex = 4
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(80, 31)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(166, 20)
        Me.tb_nama.TabIndex = 3
        '
        'tb_nis
        '
        Me.tb_nis.Location = New System.Drawing.Point(80, 8)
        Me.tb_nis.Name = "tb_nis"
        Me.tb_nis.Size = New System.Drawing.Size(166, 20)
        Me.tb_nis.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Induk"
        '
        'tp_tampil
        '
        Me.tp_tampil.Controls.Add(Me.dg_view)
        Me.tp_tampil.Location = New System.Drawing.Point(4, 22)
        Me.tp_tampil.Name = "tp_tampil"
        Me.tp_tampil.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_tampil.Size = New System.Drawing.Size(486, 212)
        Me.tp_tampil.TabIndex = 1
        Me.tp_tampil.Text = "Tampilkan Data"
        Me.tp_tampil.UseVisualStyleBackColor = True
        '
        'dg_view
        '
        Me.dg_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_view.Location = New System.Drawing.Point(3, 4)
        Me.dg_view.Name = "dg_view"
        Me.dg_view.Size = New System.Drawing.Size(487, 203)
        Me.dg_view.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 262)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tp_input.ResumeLayout(False)
        Me.tp_input.PerformLayout()
        Me.tp_tampil.ResumeLayout(False)
        CType(Me.dg_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tp_input As System.Windows.Forms.TabPage
    Friend WithEvents tp_tampil As System.Windows.Forms.TabPage
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_alamat As System.Windows.Forms.TextBox
    Friend WithEvents tb_nama As System.Windows.Forms.TextBox
    Friend WithEvents tb_nis As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg_view As System.Windows.Forms.DataGridView

End Class
