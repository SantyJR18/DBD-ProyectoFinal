﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
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
        Me.BtnEliminarPac = New System.Windows.Forms.Button()
        Me.BtnGuardarPac = New System.Windows.Forms.Button()
        Me.TBtelCliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBdireccionCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TCClientes = New System.Windows.Forms.TabControl()
        Me.TPPac = New System.Windows.Forms.TabPage()
        Me.BtnEliminarRegCli = New System.Windows.Forms.Button()
        Me.BtnEditarCli = New System.Windows.Forms.Button()
        Me.BtnNuevoCli = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarCli = New System.Windows.Forms.Button()
        Me.TBBuscCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPDetPac = New System.Windows.Forms.TabPage()
        Me.TBcorreoCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBapellidoCliente = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBnombreCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBcedulaCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCClientes.SuspendLayout()
        Me.TPPac.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPac.SuspendLayout()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminarPac
        '
        Me.BtnEliminarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarPac.Location = New System.Drawing.Point(434, 300)
        Me.BtnEliminarPac.Name = "BtnEliminarPac"
        Me.BtnEliminarPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnEliminarPac.TabIndex = 14
        Me.BtnEliminarPac.Text = "Eliminar"
        Me.BtnEliminarPac.UseVisualStyleBackColor = True
        '
        'BtnGuardarPac
        '
        Me.BtnGuardarPac.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarPac.Location = New System.Drawing.Point(271, 300)
        Me.BtnGuardarPac.Name = "BtnGuardarPac"
        Me.BtnGuardarPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnGuardarPac.TabIndex = 13
        Me.BtnGuardarPac.Text = "Guardar"
        Me.BtnGuardarPac.UseVisualStyleBackColor = True
        '
        'TBtelCliente
        '
        Me.TBtelCliente.Location = New System.Drawing.Point(579, 132)
        Me.TBtelCliente.Name = "TBtelCliente"
        Me.TBtelCliente.Size = New System.Drawing.Size(166, 20)
        Me.TBtelCliente.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(413, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Teléfono:"
        '
        'TBdireccionCliente
        '
        Me.TBdireccionCliente.Location = New System.Drawing.Point(580, 165)
        Me.TBdireccionCliente.Multiline = True
        Me.TBdireccionCliente.Name = "TBdireccionCliente"
        Me.TBdireccionCliente.Size = New System.Drawing.Size(166, 65)
        Me.TBdireccionCliente.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(413, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Correo:"
        '
        'TCClientes
        '
        Me.TCClientes.Controls.Add(Me.TPPac)
        Me.TCClientes.Controls.Add(Me.TPDetPac)
        Me.TCClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCClientes.Location = New System.Drawing.Point(0, 38)
        Me.TCClientes.Name = "TCClientes"
        Me.TCClientes.SelectedIndex = 0
        Me.TCClientes.Size = New System.Drawing.Size(794, 431)
        Me.TCClientes.TabIndex = 5
        '
        'TPPac
        '
        Me.TPPac.Controls.Add(Me.BtnEliminarRegCli)
        Me.TPPac.Controls.Add(Me.BtnEditarCli)
        Me.TPPac.Controls.Add(Me.BtnNuevoCli)
        Me.TPPac.Controls.Add(Me.DataGridView1)
        Me.TPPac.Controls.Add(Me.BtnBuscarCli)
        Me.TPPac.Controls.Add(Me.TBBuscCli)
        Me.TPPac.Controls.Add(Me.Label2)
        Me.TPPac.Location = New System.Drawing.Point(4, 22)
        Me.TPPac.Name = "TPPac"
        Me.TPPac.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPac.Size = New System.Drawing.Size(786, 405)
        Me.TPPac.TabIndex = 0
        Me.TPPac.Text = "Pacientes"
        Me.TPPac.UseVisualStyleBackColor = True
        '
        'BtnEliminarRegCli
        '
        Me.BtnEliminarRegCli.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarRegCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRegCli.Location = New System.Drawing.Point(689, 178)
        Me.BtnEliminarRegCli.Name = "BtnEliminarRegCli"
        Me.BtnEliminarRegCli.Size = New System.Drawing.Size(82, 36)
        Me.BtnEliminarRegCli.TabIndex = 6
        Me.BtnEliminarRegCli.Text = "Eliminar"
        Me.BtnEliminarRegCli.UseVisualStyleBackColor = True
        '
        'BtnEditarCli
        '
        Me.BtnEditarCli.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarCli.Location = New System.Drawing.Point(689, 122)
        Me.BtnEditarCli.Name = "BtnEditarCli"
        Me.BtnEditarCli.Size = New System.Drawing.Size(82, 37)
        Me.BtnEditarCli.TabIndex = 5
        Me.BtnEditarCli.Text = "Editar"
        Me.BtnEditarCli.UseVisualStyleBackColor = True
        '
        'BtnNuevoCli
        '
        Me.BtnNuevoCli.Image = Global.ProyectoF.My.Resources.Resources.addUser
        Me.BtnNuevoCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoCli.Location = New System.Drawing.Point(689, 67)
        Me.BtnNuevoCli.Name = "BtnNuevoCli"
        Me.BtnNuevoCli.Size = New System.Drawing.Size(82, 37)
        Me.BtnNuevoCli.TabIndex = 4
        Me.BtnNuevoCli.Text = "Nuevo"
        Me.BtnNuevoCli.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(666, 326)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnBuscarCli
        '
        Me.BtnBuscarCli.Image = Global.ProyectoF.My.Resources.Resources.searchUser
        Me.BtnBuscarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarCli.Location = New System.Drawing.Point(605, 38)
        Me.BtnBuscarCli.Name = "BtnBuscarCli"
        Me.BtnBuscarCli.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarCli.TabIndex = 2
        Me.BtnBuscarCli.Text = "Buscar"
        Me.BtnBuscarCli.UseVisualStyleBackColor = True
        '
        'TBBuscCli
        '
        Me.TBBuscCli.Location = New System.Drawing.Point(14, 38)
        Me.TBBuscCli.Name = "TBBuscCli"
        Me.TBBuscCli.Size = New System.Drawing.Size(566, 20)
        Me.TBBuscCli.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar cliente:"
        '
        'TPDetPac
        '
        Me.TPDetPac.Controls.Add(Me.BtnEliminarPac)
        Me.TPDetPac.Controls.Add(Me.BtnGuardarPac)
        Me.TPDetPac.Controls.Add(Me.TBtelCliente)
        Me.TPDetPac.Controls.Add(Me.Label9)
        Me.TPDetPac.Controls.Add(Me.TBdireccionCliente)
        Me.TPDetPac.Controls.Add(Me.Label8)
        Me.TPDetPac.Controls.Add(Me.TBcorreoCliente)
        Me.TPDetPac.Controls.Add(Me.Label6)
        Me.TPDetPac.Controls.Add(Me.TBapellidoCliente)
        Me.TPDetPac.Controls.Add(Me.Label5)
        Me.TPDetPac.Controls.Add(Me.TBnombreCliente)
        Me.TPDetPac.Controls.Add(Me.Label3)
        Me.TPDetPac.Controls.Add(Me.TBcedulaCliente)
        Me.TPDetPac.Controls.Add(Me.Label4)
        Me.TPDetPac.Location = New System.Drawing.Point(4, 22)
        Me.TPDetPac.Name = "TPDetPac"
        Me.TPDetPac.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDetPac.Size = New System.Drawing.Size(786, 405)
        Me.TPDetPac.TabIndex = 1
        Me.TPDetPac.Text = "Detalles"
        Me.TPDetPac.UseVisualStyleBackColor = True
        '
        'TBcorreoCliente
        '
        Me.TBcorreoCliente.Location = New System.Drawing.Point(580, 96)
        Me.TBcorreoCliente.Name = "TBcorreoCliente"
        Me.TBcorreoCliente.Size = New System.Drawing.Size(166, 20)
        Me.TBcorreoCliente.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(413, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dirección:"
        '
        'TBapellidoCliente
        '
        Me.TBapellidoCliente.FormattingEnabled = True
        Me.TBapellidoCliente.Location = New System.Drawing.Point(207, 164)
        Me.TBapellidoCliente.Name = "TBapellidoCliente"
        Me.TBapellidoCliente.Size = New System.Drawing.Size(166, 21)
        Me.TBapellidoCliente.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Apellido:"
        '
        'TBnombreCliente
        '
        Me.TBnombreCliente.Location = New System.Drawing.Point(207, 130)
        Me.TBnombreCliente.Name = "TBnombreCliente"
        Me.TBnombreCliente.Size = New System.Drawing.Size(166, 20)
        Me.TBnombreCliente.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre:"
        '
        'TBcedulaCliente
        '
        Me.TBcedulaCliente.Location = New System.Drawing.Point(207, 97)
        Me.TBcedulaCliente.Name = "TBcedulaCliente"
        Me.TBcedulaCliente.Size = New System.Drawing.Size(98, 20)
        Me.TBcedulaCliente.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cédula:"
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTitle.Controls.Add(Me.Label1)
        Me.PnlTitle.Controls.Add(Me.BtnCerrar)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(794, 38)
        Me.PnlTitle.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(750, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 469)
        Me.Controls.Add(Me.TCClientes)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmClientes"
        Me.Text = "FrmClientes"
        Me.TCClientes.ResumeLayout(False)
        Me.TPPac.ResumeLayout(False)
        Me.TPPac.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPac.ResumeLayout(False)
        Me.TPDetPac.PerformLayout()
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnEliminarRegCli As Button
    Friend WithEvents BtnEditarCli As Button
    Friend WithEvents BtnNuevoCli As Button
    Friend WithEvents BtnBuscarCli As Button
    Friend WithEvents BtnEliminarPac As Button
    Friend WithEvents BtnGuardarPac As Button
    Friend WithEvents TBtelCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TCClientes As TabControl
    Friend WithEvents TPPac As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TBBuscCli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TPDetPac As TabPage
    Friend WithEvents TBcorreoCliente As TextBox
    Friend WithEvents TBdireccionCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBapellidoCliente As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBnombreCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBcedulaCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
End Class
