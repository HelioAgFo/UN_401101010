'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        m_IsInitializing = true
        InitializeComponent()
        m_IsInitializing = False
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Update1 As Microsoft.Dynamics.SL.Controls.DSLUpdate
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Update1 = New Microsoft.Dynamics.SL.Controls.DSLUpdate()
        Me.SAFHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cCustid = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cShipperid = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cCustidd = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.DslGrid1 = New Microsoft.Dynamics.SL.Controls.DSLGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DslGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Update1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Update1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update1.Image = CType(resources.GetObject("Update1.Image"), System.Drawing.Image)
        Me.Update1.Levels = "Customer;N,Shoshipheader;D"
        Me.Update1.Location = New System.Drawing.Point(553, 12)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(25, 25)
        Me.Update1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Update1.TabIndex = 0
        Me.Update1.TabStop = False
        Me.Update1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cCustid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 89)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'cCustid
        '
        Me.cCustid.FieldName = """bCustomer.Custid""; 0; 0; 15"
        Me.cCustid.Heading = "Custid"
        Me.cCustid.InGrid = False
        Me.cCustid.Level = "0,K"
        Me.cCustid.Location = New System.Drawing.Point(100, 39)
        Me.cCustid.Mask = "UU-WWWWWWWW"
        Me.cCustid.Name = "cCustid"
        Me.cCustid.PV = """customer_all"", "
        Me.cCustid.Size = New System.Drawing.Size(127, 22)
        Me.cCustid.TabIndex = 2
        Me.cCustid.TextLength = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No Embarque:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cliente:"
        '
        'cShipperid
        '
        Me.cShipperid.FieldName = """bSoshipheader.shipperid""; 0; 0; 15"
        Me.cShipperid.Heading = "No. Embarque:"
        Me.cShipperid.Level = "1"
        Me.cShipperid.Location = New System.Drawing.Point(130, 30)
        Me.cShipperid.Mask = "xxxxxxxxxxxxxxx"
        Me.cShipperid.Name = "cShipperid"
        Me.cShipperid.Size = New System.Drawing.Size(120, 22)
        Me.cShipperid.TabIndex = 2
        Me.cShipperid.TextLength = 15
        '
        'cCustidd
        '
        Me.cCustidd.FieldName = """bSoshipheader.Custid""; 0; 0; 15"
        Me.cCustidd.Heading = "Cliente:"
        Me.cCustidd.Level = "1"
        Me.cCustidd.Location = New System.Drawing.Point(130, 60)
        Me.cCustidd.Mask = "xxxxxxxxxxxxxxx"
        Me.cCustidd.Name = "cCustidd"
        Me.cCustidd.Size = New System.Drawing.Size(120, 22)
        Me.cCustidd.TabIndex = 3
        Me.cCustidd.TextLength = 15
        '
        'DslGrid1
        '
        Me.DslGrid1.Location = New System.Drawing.Point(83, 114)
        Me.DslGrid1.Name = "DslGrid1"
        Me.DslGrid1.OcxState = CType(resources.GetObject("DslGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DslGrid1.Size = New System.Drawing.Size(200, 120)
        Me.DslGrid1.SetSLDBNav(Me.DslGrid1, """xShoshipheader_All"", ""bCustomer.Custid""; 0; 0; 0; 0, ")
        Me.DslGrid1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DslGrid1)
        Me.GroupBox2.Controls.Add(Me.cCustidd)
        Me.GroupBox2.Controls.Add(Me.cShipperid)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(566, 350)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(590, 485)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Update1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Agrupar Facturas 40.110.10"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DslGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cCustid As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cShipperid As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cCustidd As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents DslGrid1 As Microsoft.Dynamics.SL.Controls.DSLGrid
    Friend WithEvents GroupBox2 As GroupBox
#End Region
End Class
