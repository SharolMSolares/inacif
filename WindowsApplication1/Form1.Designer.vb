<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim NombreLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Dim ADNLabel As System.Windows.Forms.Label
        Dim Causa_de_MuerteLabel As System.Windows.Forms.Label
        Dim Fecha_de_FallecimientoLabel As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim Muestra_de_ReferenciaLabel As System.Windows.Forms.Label
        Dim Nombre_de_Forence_a_CargoLabel As System.Windows.Forms.Label
        Dim Area_a_CargoLabel As System.Windows.Forms.Label
        Me.InacifDataSet = New WindowsApplication1.inacifDataSet()
        Me.CadaveresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CadaveresTableAdapter = New WindowsApplication1.inacifDataSetTableAdapters.cadaveresTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.inacifDataSetTableAdapters.TableAdapterManager()
        Me.CadaveresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CadaveresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.SexoTextBox = New System.Windows.Forms.TextBox()
        Me.EdadTextBox = New System.Windows.Forms.TextBox()
        Me.ADNTextBox = New System.Windows.Forms.TextBox()
        Me.Causa_de_MuerteTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_de_FallecimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NacionalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Muestra_de_ReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_de_Forence_a_CargoTextBox = New System.Windows.Forms.TextBox()
        Me.Area_a_CargoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        ADNLabel = New System.Windows.Forms.Label()
        Causa_de_MuerteLabel = New System.Windows.Forms.Label()
        Fecha_de_FallecimientoLabel = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        Muestra_de_ReferenciaLabel = New System.Windows.Forms.Label()
        Nombre_de_Forence_a_CargoLabel = New System.Windows.Forms.Label()
        Area_a_CargoLabel = New System.Windows.Forms.Label()
        CType(Me.InacifDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadaveresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadaveresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CadaveresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'InacifDataSet
        '
        Me.InacifDataSet.DataSetName = "inacifDataSet"
        Me.InacifDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CadaveresBindingSource
        '
        Me.CadaveresBindingSource.DataMember = "cadaveres"
        Me.CadaveresBindingSource.DataSource = Me.InacifDataSet
        '
        'CadaveresTableAdapter
        '
        Me.CadaveresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cadaveresTableAdapter = Me.CadaveresTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.inacifDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CadaveresBindingNavigator
        '
        Me.CadaveresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CadaveresBindingNavigator.BindingSource = Me.CadaveresBindingSource
        Me.CadaveresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CadaveresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CadaveresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CadaveresBindingNavigatorSaveItem})
        Me.CadaveresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CadaveresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CadaveresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CadaveresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CadaveresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CadaveresBindingNavigator.Name = "CadaveresBindingNavigator"
        Me.CadaveresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CadaveresBindingNavigator.Size = New System.Drawing.Size(575, 25)
        Me.CadaveresBindingNavigator.TabIndex = 0
        Me.CadaveresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'CadaveresBindingNavigatorSaveItem
        '
        Me.CadaveresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CadaveresBindingNavigatorSaveItem.Image = CType(resources.GetObject("CadaveresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CadaveresBindingNavigatorSaveItem.Name = "CadaveresBindingNavigatorSaveItem"
        Me.CadaveresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CadaveresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(22, 31)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadaveresBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(75, 28)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(35, 53)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(34, 13)
        SexoLabel.TabIndex = 3
        SexoLabel.Text = "Sexo:"
        '
        'SexoTextBox
        '
        Me.SexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadaveresBindingSource, "Sexo", True))
        Me.SexoTextBox.Location = New System.Drawing.Point(75, 50)
        Me.SexoTextBox.Name = "SexoTextBox"
        Me.SexoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SexoTextBox.TabIndex = 4
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Location = New System.Drawing.Point(35, 75)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(35, 13)
        EdadLabel.TabIndex = 5
        EdadLabel.Text = "Edad:"
        '
        'EdadTextBox
        '
        Me.EdadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadaveresBindingSource, "Edad", True))
        Me.EdadTextBox.Location = New System.Drawing.Point(76, 72)
        Me.EdadTextBox.Name = "EdadTextBox"
        Me.EdadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EdadTextBox.TabIndex = 6
        '
        'ADNLabel
        '
        ADNLabel.AutoSize = True
        ADNLabel.Location = New System.Drawing.Point(37, 100)
        ADNLabel.Name = "ADNLabel"
        ADNLabel.Size = New System.Drawing.Size(33, 13)
        ADNLabel.TabIndex = 7
        ADNLabel.Text = "ADN:"
        '
        'ADNTextBox
        '
        Me.ADNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadaveresBindingSource, "ADN", True))
        Me.ADNTextBox.Location = New System.Drawing.Point(76, 97)
        Me.ADNTextBox.Name = "ADNTextBox"
        Me.ADNTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ADNTextBox.TabIndex = 8
        '
        'Causa_de_MuerteLabel
        '
        Causa_de_MuerteLabel.AutoSize = True
        Causa_de_MuerteLabel.Location = New System.Drawing.Point(239, 38)
        Causa_de_MuerteLabel.Name = "Causa_de_MuerteLabel"
        Causa_de_MuerteLabel.Size = New System.Drawing.Size(91, 13)
        Causa_de_MuerteLabel.TabIndex = 9
        Causa_de_MuerteLabel.Text = "Causa de Muerte:"
        '
        'Causa_de_MuerteTextBox
        '
        Me.Causa_de_MuerteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadaveresBindingSource, "Causa de Muerte", True))
        Me.Causa_de_MuerteTextBox.Location = New System.Drawing.Point(336, 24)
        Me.Causa_de_MuerteTextBox.Name = "Causa_de_MuerteTextBox"
        Me.Causa_de_MuerteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Causa_de_MuerteTextBox.TabIndex = 10
        '
        'Fecha_de_FallecimientoLabel
        '
        Fecha_de_FallecimientoLabel.AutoSize = True
        Fecha_de_FallecimientoLabel.Location = New System.Drawing.Point(211, 62)
        Fecha_de_FallecimientoLabel.Name = "Fecha_de_FallecimientoLabel"
        Fecha_de_FallecimientoLabel.Size = New System.Drawing.Size(119, 13)
        Fecha_de_FallecimientoLabel.TabIndex = 11
        Fecha_de_FallecimientoLabel.Text = "Fecha de Fallecimiento:"
        '
        'Fecha_de_FallecimientoDateTimePicker
        '
        Me.Fecha_de_FallecimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CadaveresBindingSource, "Fecha de Fallecimiento", True))
        Me.Fecha_de_FallecimientoDateTimePicker.Location = New System.Drawing.Point(336, 46)
        Me.Fecha_de_FallecimientoDateTimePicker.Name = "Fecha_de_FallecimientoDateTimePicker"
        Me.Fecha_de_FallecimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_de_FallecimientoDateTimePicker.TabIndex = 12
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Location = New System.Drawing.Point(258, 79)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(72, 13)
        NacionalidadLabel.TabIndex = 13
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'NacionalidadTextBox
        '
        Me.NacionalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadaveresBindingSource, "Nacionalidad", True))
        Me.NacionalidadTextBox.Location = New System.Drawing.Point(336, 72)
        Me.NacionalidadTextBox.Name = "NacionalidadTextBox"
        Me.NacionalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NacionalidadTextBox.TabIndex = 14
        '
        'Muestra_de_ReferenciaLabel
        '
        Muestra_de_ReferenciaLabel.AutoSize = True
        Muestra_de_ReferenciaLabel.Location = New System.Drawing.Point(172, 133)
        Muestra_de_ReferenciaLabel.Name = "Muestra_de_ReferenciaLabel"
        Muestra_de_ReferenciaLabel.Size = New System.Drawing.Size(118, 13)
        Muestra_de_ReferenciaLabel.TabIndex = 15
        Muestra_de_ReferenciaLabel.Text = "Muestra de Referencia:"
        '
        'Muestra_de_ReferenciaTextBox
        '
        Me.Muestra_de_ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadaveresBindingSource, "Muestra de Referencia", True))
        Me.Muestra_de_ReferenciaTextBox.Location = New System.Drawing.Point(296, 130)
        Me.Muestra_de_ReferenciaTextBox.Name = "Muestra_de_ReferenciaTextBox"
        Me.Muestra_de_ReferenciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Muestra_de_ReferenciaTextBox.TabIndex = 16
        '
        'Nombre_de_Forence_a_CargoLabel
        '
        Nombre_de_Forence_a_CargoLabel.AutoSize = True
        Nombre_de_Forence_a_CargoLabel.Location = New System.Drawing.Point(100, 170)
        Nombre_de_Forence_a_CargoLabel.Name = "Nombre_de_Forence_a_CargoLabel"
        Nombre_de_Forence_a_CargoLabel.Size = New System.Drawing.Size(144, 13)
        Nombre_de_Forence_a_CargoLabel.TabIndex = 17
        Nombre_de_Forence_a_CargoLabel.Text = "Nombre de Forence a Cargo:"
        '
        'Nombre_de_Forence_a_CargoTextBox
        '
        Me.Nombre_de_Forence_a_CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadaveresBindingSource, "Nombre de Forence a Cargo", True))
        Me.Nombre_de_Forence_a_CargoTextBox.Location = New System.Drawing.Point(250, 163)
        Me.Nombre_de_Forence_a_CargoTextBox.Name = "Nombre_de_Forence_a_CargoTextBox"
        Me.Nombre_de_Forence_a_CargoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_de_Forence_a_CargoTextBox.TabIndex = 18
        '
        'Area_a_CargoLabel
        '
        Area_a_CargoLabel.AutoSize = True
        Area_a_CargoLabel.Location = New System.Drawing.Point(172, 192)
        Area_a_CargoLabel.Name = "Area_a_CargoLabel"
        Area_a_CargoLabel.Size = New System.Drawing.Size(72, 13)
        Area_a_CargoLabel.TabIndex = 19
        Area_a_CargoLabel.Text = "Area a Cargo:"
        '
        'Area_a_CargoTextBox
        '
        Me.Area_a_CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadaveresBindingSource, "Area a Cargo", True))
        Me.Area_a_CargoTextBox.Location = New System.Drawing.Point(250, 189)
        Me.Area_a_CargoTextBox.Name = "Area_a_CargoTextBox"
        Me.Area_a_CargoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Area_a_CargoTextBox.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(226, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(-17, 227)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Anterior"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(145, 227)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Mas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(307, 227)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Guardar Datos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 262)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Area_a_CargoLabel)
        Me.Controls.Add(Me.Area_a_CargoTextBox)
        Me.Controls.Add(Nombre_de_Forence_a_CargoLabel)
        Me.Controls.Add(Me.Nombre_de_Forence_a_CargoTextBox)
        Me.Controls.Add(Muestra_de_ReferenciaLabel)
        Me.Controls.Add(Me.Muestra_de_ReferenciaTextBox)
        Me.Controls.Add(NacionalidadLabel)
        Me.Controls.Add(Me.NacionalidadTextBox)
        Me.Controls.Add(Fecha_de_FallecimientoLabel)
        Me.Controls.Add(Me.Fecha_de_FallecimientoDateTimePicker)
        Me.Controls.Add(Causa_de_MuerteLabel)
        Me.Controls.Add(Me.Causa_de_MuerteTextBox)
        Me.Controls.Add(ADNLabel)
        Me.Controls.Add(Me.ADNTextBox)
        Me.Controls.Add(EdadLabel)
        Me.Controls.Add(Me.EdadTextBox)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(Me.SexoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.CadaveresBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.InacifDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadaveresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadaveresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CadaveresBindingNavigator.ResumeLayout(False)
        Me.CadaveresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InacifDataSet As inacifDataSet
    Friend WithEvents CadaveresBindingSource As BindingSource
    Friend WithEvents CadaveresTableAdapter As inacifDataSetTableAdapters.cadaveresTableAdapter
    Friend WithEvents TableAdapterManager As inacifDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CadaveresBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CadaveresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents SexoTextBox As TextBox
    Friend WithEvents EdadTextBox As TextBox
    Friend WithEvents ADNTextBox As TextBox
    Friend WithEvents Causa_de_MuerteTextBox As TextBox
    Friend WithEvents Fecha_de_FallecimientoDateTimePicker As DateTimePicker
    Friend WithEvents NacionalidadTextBox As TextBox
    Friend WithEvents Muestra_de_ReferenciaTextBox As TextBox
    Friend WithEvents Nombre_de_Forence_a_CargoTextBox As TextBox
    Friend WithEvents Area_a_CargoTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
