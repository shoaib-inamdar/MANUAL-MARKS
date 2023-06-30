<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROLLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXP1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXP2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXP3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXP4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXP5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GADMARKSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GAD_MARKSDataSet = New WindowsApplication2.GAD_MARKSDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GADDataSet = New WindowsApplication2.GADDataSet()
        Me.Table1TableAdapter = New WindowsApplication2.GADDataSetTableAdapters.Table1TableAdapter()
        Me.Table1TableAdapter1 = New WindowsApplication2.GAD_MARKSDataSetTableAdapters.Table1TableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GADMARKSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GAD_MARKSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAMEDataGridViewTextBoxColumn, Me.ROLLDataGridViewTextBoxColumn, Me.EXP1DataGridViewTextBoxColumn, Me.EXP2DataGridViewTextBoxColumn, Me.EXP3DataGridViewTextBoxColumn, Me.EXP4DataGridViewTextBoxColumn, Me.EXP5DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1061, 456)
        Me.DataGridView1.TabIndex = 0
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        Me.NAMEDataGridViewTextBoxColumn.Width = 150
        '
        'ROLLDataGridViewTextBoxColumn
        '
        Me.ROLLDataGridViewTextBoxColumn.DataPropertyName = "ROLL"
        Me.ROLLDataGridViewTextBoxColumn.HeaderText = "ROLL"
        Me.ROLLDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ROLLDataGridViewTextBoxColumn.Name = "ROLLDataGridViewTextBoxColumn"
        Me.ROLLDataGridViewTextBoxColumn.Width = 150
        '
        'EXP1DataGridViewTextBoxColumn
        '
        Me.EXP1DataGridViewTextBoxColumn.DataPropertyName = "EXP1"
        Me.EXP1DataGridViewTextBoxColumn.HeaderText = "EXP1"
        Me.EXP1DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EXP1DataGridViewTextBoxColumn.Name = "EXP1DataGridViewTextBoxColumn"
        Me.EXP1DataGridViewTextBoxColumn.Width = 150
        '
        'EXP2DataGridViewTextBoxColumn
        '
        Me.EXP2DataGridViewTextBoxColumn.DataPropertyName = "EXP2"
        Me.EXP2DataGridViewTextBoxColumn.HeaderText = "EXP2"
        Me.EXP2DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EXP2DataGridViewTextBoxColumn.Name = "EXP2DataGridViewTextBoxColumn"
        Me.EXP2DataGridViewTextBoxColumn.Width = 150
        '
        'EXP3DataGridViewTextBoxColumn
        '
        Me.EXP3DataGridViewTextBoxColumn.DataPropertyName = "EXP3"
        Me.EXP3DataGridViewTextBoxColumn.HeaderText = "EXP3"
        Me.EXP3DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EXP3DataGridViewTextBoxColumn.Name = "EXP3DataGridViewTextBoxColumn"
        Me.EXP3DataGridViewTextBoxColumn.Width = 150
        '
        'EXP4DataGridViewTextBoxColumn
        '
        Me.EXP4DataGridViewTextBoxColumn.DataPropertyName = "EXP4"
        Me.EXP4DataGridViewTextBoxColumn.HeaderText = "EXP4"
        Me.EXP4DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EXP4DataGridViewTextBoxColumn.Name = "EXP4DataGridViewTextBoxColumn"
        Me.EXP4DataGridViewTextBoxColumn.Width = 150
        '
        'EXP5DataGridViewTextBoxColumn
        '
        Me.EXP5DataGridViewTextBoxColumn.DataPropertyName = "EXP5"
        Me.EXP5DataGridViewTextBoxColumn.HeaderText = "EXP5"
        Me.EXP5DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EXP5DataGridViewTextBoxColumn.Name = "EXP5DataGridViewTextBoxColumn"
        Me.EXP5DataGridViewTextBoxColumn.Width = 150
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table1"
        Me.Table1BindingSource1.DataSource = Me.GADMARKSDataSetBindingSource
        '
        'GADMARKSDataSetBindingSource
        '
        Me.GADMARKSDataSetBindingSource.DataSource = Me.GAD_MARKSDataSet
        Me.GADMARKSDataSetBindingSource.Position = 0
        '
        'GAD_MARKSDataSet
        '
        Me.GAD_MARKSDataSet.DataSetName = "GAD_MARKSDataSet"
        Me.GAD_MARKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(12, 474)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1061, 99)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.GADDataSet
        '
        'GADDataSet
        '
        Me.GADDataSet.DataSetName = "GADDataSet"
        Me.GADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Table1TableAdapter1
        '
        Me.Table1TableAdapter1.ClearBeforeFill = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 585)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form8"
        Me.Text = "gad data"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GADMARKSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GAD_MARKSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GADDataSet As WindowsApplication2.GADDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As WindowsApplication2.GADDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GADMARKSDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GAD_MARKSDataSet As WindowsApplication2.GAD_MARKSDataSet
    Friend WithEvents Table1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter1 As WindowsApplication2.GAD_MARKSDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ROLLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXP1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXP2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXP3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXP4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXP5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
