﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPacientesR
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
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCPacientesRec = New System.Windows.Forms.TabControl()
        Me.TPPacienteRec = New System.Windows.Forms.TabPage()
        Me.BtnEliminarRegPac = New System.Windows.Forms.Button()
        Me.BtnEditarPac = New System.Windows.Forms.Button()
        Me.BtnNuevoPac = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarPacRec = New System.Windows.Forms.Button()
        Me.TBBuscarPac = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPDetPacRec = New System.Windows.Forms.TabPage()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TBNombrePac = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBFechaNac = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBSenPar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBColorPac = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBRazaPac = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBSexoPac = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBEspeciePac = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBIdPac = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCPacientesRec.SuspendLayout()
        Me.TPPacienteRec.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPacRec.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTitle.Controls.Add(Me.Label1)
        Me.PnlTitle.Controls.Add(Me.BtnCerrar)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(1028, 38)
        Me.PnlTitle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pacientes"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(984, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'TCPacientesRec
        '
        Me.TCPacientesRec.Controls.Add(Me.TPPacienteRec)
        Me.TCPacientesRec.Controls.Add(Me.TPDetPacRec)
        Me.TCPacientesRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientesRec.Location = New System.Drawing.Point(0, 38)
        Me.TCPacientesRec.Name = "TCPacientesRec"
        Me.TCPacientesRec.SelectedIndex = 0
        Me.TCPacientesRec.Size = New System.Drawing.Size(1028, 571)
        Me.TCPacientesRec.TabIndex = 3
        '
        'TPPacienteRec
        '
        Me.TPPacienteRec.BackColor = System.Drawing.Color.SeaShell
        Me.TPPacienteRec.Controls.Add(Me.BtnEliminarRegPac)
        Me.TPPacienteRec.Controls.Add(Me.BtnEditarPac)
        Me.TPPacienteRec.Controls.Add(Me.BtnNuevoPac)
        Me.TPPacienteRec.Controls.Add(Me.DataGridView1)
        Me.TPPacienteRec.Controls.Add(Me.BtnBuscarPacRec)
        Me.TPPacienteRec.Controls.Add(Me.TBBuscarPac)
        Me.TPPacienteRec.Controls.Add(Me.Label2)
        Me.TPPacienteRec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TPPacienteRec.Location = New System.Drawing.Point(4, 22)
        Me.TPPacienteRec.Name = "TPPacienteRec"
        Me.TPPacienteRec.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPacienteRec.Size = New System.Drawing.Size(1020, 545)
        Me.TPPacienteRec.TabIndex = 0
        Me.TPPacienteRec.Text = "Pacientes"
        '
        'BtnEliminarRegPac
        '
        Me.BtnEliminarRegPac.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarRegPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRegPac.Location = New System.Drawing.Point(808, 247)
        Me.BtnEliminarRegPac.Name = "BtnEliminarRegPac"
        Me.BtnEliminarRegPac.Size = New System.Drawing.Size(82, 36)
        Me.BtnEliminarRegPac.TabIndex = 6
        Me.BtnEliminarRegPac.Text = "Eliminar"
        Me.BtnEliminarRegPac.UseVisualStyleBackColor = True
        '
        'BtnEditarPac
        '
        Me.BtnEditarPac.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarPac.Location = New System.Drawing.Point(808, 191)
        Me.BtnEditarPac.Name = "BtnEditarPac"
        Me.BtnEditarPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnEditarPac.TabIndex = 5
        Me.BtnEditarPac.Text = "Editar"
        Me.BtnEditarPac.UseVisualStyleBackColor = True
        '
        'BtnNuevoPac
        '
        Me.BtnNuevoPac.Image = Global.ProyectoF.My.Resources.Resources.pet_care
        Me.BtnNuevoPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoPac.Location = New System.Drawing.Point(808, 136)
        Me.BtnNuevoPac.Name = "BtnNuevoPac"
        Me.BtnNuevoPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnNuevoPac.TabIndex = 4
        Me.BtnNuevoPac.Text = "Nuevo"
        Me.BtnNuevoPac.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(133, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(666, 326)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnBuscarPacRec
        '
        Me.BtnBuscarPacRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarPacRec.Location = New System.Drawing.Point(724, 107)
        Me.BtnBuscarPacRec.Name = "BtnBuscarPacRec"
        Me.BtnBuscarPacRec.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarPacRec.TabIndex = 2
        Me.BtnBuscarPacRec.Text = "Buscar"
        Me.BtnBuscarPacRec.UseVisualStyleBackColor = True
        '
        'TBBuscarPac
        '
        Me.TBBuscarPac.Location = New System.Drawing.Point(133, 107)
        Me.TBBuscarPac.Name = "TBBuscarPac"
        Me.TBBuscarPac.Size = New System.Drawing.Size(566, 20)
        Me.TBBuscarPac.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar paciente:"
        '
        'TPDetPacRec
        '
        Me.TPDetPacRec.BackColor = System.Drawing.Color.SeaShell
        Me.TPDetPacRec.Controls.Add(Me.BtnGuardar)
        Me.TPDetPacRec.Controls.Add(Me.BtnCancelar)
        Me.TPDetPacRec.Controls.Add(Me.TBNombrePac)
        Me.TPDetPacRec.Controls.Add(Me.Label10)
        Me.TPDetPacRec.Controls.Add(Me.TBFechaNac)
        Me.TPDetPacRec.Controls.Add(Me.Label9)
        Me.TPDetPacRec.Controls.Add(Me.TBSenPar)
        Me.TPDetPacRec.Controls.Add(Me.Label8)
        Me.TPDetPacRec.Controls.Add(Me.TBColorPac)
        Me.TPDetPacRec.Controls.Add(Me.Label7)
        Me.TPDetPacRec.Controls.Add(Me.TBRazaPac)
        Me.TPDetPacRec.Controls.Add(Me.Label6)
        Me.TPDetPacRec.Controls.Add(Me.TBSexoPac)
        Me.TPDetPacRec.Controls.Add(Me.Label5)
        Me.TPDetPacRec.Controls.Add(Me.TBEspeciePac)
        Me.TPDetPacRec.Controls.Add(Me.Label3)
        Me.TPDetPacRec.Controls.Add(Me.TBIdPac)
        Me.TPDetPacRec.Controls.Add(Me.Label4)
        Me.TPDetPacRec.Location = New System.Drawing.Point(4, 22)
        Me.TPDetPacRec.Name = "TPDetPacRec"
        Me.TPDetPacRec.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDetPacRec.Size = New System.Drawing.Size(1020, 545)
        Me.TPDetPacRec.TabIndex = 1
        Me.TPDetPacRec.Text = "Detalles"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(390, 348)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 37)
        Me.BtnGuardar.TabIndex = 19
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.ProyectoF.My.Resources.Resources.close
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(533, 348)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 37)
        Me.BtnCancelar.TabIndex = 20
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TBNombrePac
        '
        Me.TBNombrePac.Location = New System.Drawing.Point(696, 195)
        Me.TBNombrePac.Name = "TBNombrePac"
        Me.TBNombrePac.Size = New System.Drawing.Size(166, 20)
        Me.TBNombrePac.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(530, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Fecha Nacimiento:"
        '
        'TBFechaNac
        '
        Me.TBFechaNac.Location = New System.Drawing.Point(697, 228)
        Me.TBFechaNac.Name = "TBFechaNac"
        Me.TBFechaNac.Size = New System.Drawing.Size(166, 20)
        Me.TBFechaNac.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(530, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nombre:"
        '
        'TBSenPar
        '
        Me.TBSenPar.Location = New System.Drawing.Point(697, 263)
        Me.TBSenPar.Multiline = True
        Me.TBSenPar.Name = "TBSenPar"
        Me.TBSenPar.Size = New System.Drawing.Size(166, 65)
        Me.TBSenPar.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(530, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Color:"
        '
        'TBColorPac
        '
        Me.TBColorPac.Location = New System.Drawing.Point(697, 159)
        Me.TBColorPac.Name = "TBColorPac"
        Me.TBColorPac.Size = New System.Drawing.Size(166, 20)
        Me.TBColorPac.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(157, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Raza:"
        '
        'TBRazaPac
        '
        Me.TBRazaPac.Location = New System.Drawing.Point(324, 261)
        Me.TBRazaPac.Name = "TBRazaPac"
        Me.TBRazaPac.Size = New System.Drawing.Size(166, 20)
        Me.TBRazaPac.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(530, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Señas particulares:"
        '
        'TBSexoPac
        '
        Me.TBSexoPac.FormattingEnabled = True
        Me.TBSexoPac.Location = New System.Drawing.Point(324, 227)
        Me.TBSexoPac.Name = "TBSexoPac"
        Me.TBSexoPac.Size = New System.Drawing.Size(166, 21)
        Me.TBSexoPac.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sexo:"
        '
        'TBEspeciePac
        '
        Me.TBEspeciePac.Location = New System.Drawing.Point(324, 193)
        Me.TBEspeciePac.Name = "TBEspeciePac"
        Me.TBEspeciePac.Size = New System.Drawing.Size(166, 20)
        Me.TBEspeciePac.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Especie:"
        '
        'TBIdPac
        '
        Me.TBIdPac.Location = New System.Drawing.Point(324, 160)
        Me.TBIdPac.Name = "TBIdPac"
        Me.TBIdPac.Size = New System.Drawing.Size(98, 20)
        Me.TBIdPac.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ID del paciente:"
        '
        'FrmPacientesR
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.TCPacientesRec)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPacientesR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPacientes"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TCPacientesRec.ResumeLayout(False)
        Me.TPPacienteRec.ResumeLayout(False)
        Me.TPPacienteRec.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPacRec.ResumeLayout(False)
        Me.TPDetPacRec.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TCPacientesRec As TabControl
    Friend WithEvents TPPacienteRec As TabPage
    Friend WithEvents TPDetPacRec As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscarPacRec As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnEliminarRegPac As Button
    Friend WithEvents BtnEditarPac As Button
    Friend WithEvents BtnNuevoPac As Button
    Friend WithEvents TBBuscarPac As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBIdPac As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBEspeciePac As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBRazaPac As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBSexoPac As ComboBox
    Friend WithEvents TBColorPac As TextBox
    Friend WithEvents TBSenPar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBNombrePac As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBFechaNac As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
End Class
