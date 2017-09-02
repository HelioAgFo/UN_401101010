'*****************************************************************************
' <Copyright File='Customer.sdo.vb' Company='JanuSanthosh Inc'> 
' Dynamics SL - DH File Creation
' Created by D.Santhosh - SL Consultant 
' </Copyright> 
'*****************************************************************************
Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoCustomer
Public Class Customer
Inherits SolomonDataObject
< _
DataBinding(PropertyIndex:=0, StringSize:=10) _
> _
Public Property AccrRevAcct() As String
     Get
          Return Me.GetPropertyValue("AccrRevAcct")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("AccrRevAcct", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=1, StringSize:=24) _
> _
Public Property AccrRevSub() As String
     Get
          Return Me.GetPropertyValue("AccrRevSub")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("AccrRevSub", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=2, StringSize:=30) _
> _
Public Property AcctNbr() As String
     Get
          Return Me.GetPropertyValue("AcctNbr")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("AcctNbr", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=3, StringSize:=60) _
> _
Public Property Addr1() As String
     Get
          Return Me.GetPropertyValue("Addr1")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Addr1", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=4, StringSize:=60) _
> _
Public Property Addr2() As String
     Get
          Return Me.GetPropertyValue("Addr2")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Addr2", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=5, StringSize:=10) _
> _
Public Property AgentID() As String
     Get
          Return Me.GetPropertyValue("AgentID")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("AgentID", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=6) _
> _
Public Property ApplFinChrg() As Short
     Get
          Return Me.GetPropertyValue("ApplFinChrg")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("ApplFinChrg", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=7, StringSize:=10) _
> _
Public Property ArAcct() As String
     Get
          Return Me.GetPropertyValue("ArAcct")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("ArAcct", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=8, StringSize:=24) _
> _
Public Property ArSub() As String
     Get
          Return Me.GetPropertyValue("ArSub")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("ArSub", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=9, StringSize:=30) _
> _
Public Property Attn() As String
     Get
          Return Me.GetPropertyValue("Attn")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Attn", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=10) _
> _
Public Property AutoApply() As Short
     Get
          Return Me.GetPropertyValue("AutoApply")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("AutoApply", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=11, StringSize:=10) _
> _
Public Property BankID() As String
     Get
          Return Me.GetPropertyValue("BankID")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BankID", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=12, StringSize:=60) _
> _
Public Property BillAddr1() As String
     Get
          Return Me.GetPropertyValue("BillAddr1")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillAddr1", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=13, StringSize:=60) _
> _
Public Property BillAddr2() As String
     Get
          Return Me.GetPropertyValue("BillAddr2")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillAddr2", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=14, StringSize:=30) _
> _
Public Property BillAttn() As String
     Get
          Return Me.GetPropertyValue("BillAttn")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillAttn", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=15, StringSize:=30) _
> _
Public Property BillCity() As String
     Get
          Return Me.GetPropertyValue("BillCity")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillCity", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=16, StringSize:=3) _
> _
Public Property BillCountry() As String
     Get
          Return Me.GetPropertyValue("BillCountry")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillCountry", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=17, StringSize:=30) _
> _
Public Property BillFax() As String
     Get
          Return Me.GetPropertyValue("BillFax")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillFax", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=18, StringSize:=60) _
> _
Public Property BillName() As String
     Get
          Return Me.GetPropertyValue("BillName")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillName", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=19, StringSize:=30) _
> _
Public Property BillPhone() As String
     Get
          Return Me.GetPropertyValue("BillPhone")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillPhone", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=20, StringSize:=30) _
> _
Public Property BillSalut() As String
     Get
          Return Me.GetPropertyValue("BillSalut")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillSalut", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=21, StringSize:=3) _
> _
Public Property BillState() As String
     Get
          Return Me.GetPropertyValue("BillState")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillState", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=22) _
> _
Public Property BillThruProject() As Short
     Get
          Return Me.GetPropertyValue("BillThruProject")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("BillThruProject", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=23, StringSize:=10) _
> _
Public Property BillZip() As String
     Get
          Return Me.GetPropertyValue("BillZip")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("BillZip", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=24) _
> _
Public Property CardExpDate() As Integer
     Get
          Return Me.GetPropertyValue("CardExpDate")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("CardExpDate", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=25, StringSize:=60) _
> _
Public Property CardHldrName() As String
     Get
          Return Me.GetPropertyValue("CardHldrName")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CardHldrName", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=26, StringSize:=20) _
> _
Public Property CardNbr() As String
     Get
          Return Me.GetPropertyValue("CardNbr")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CardNbr", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=27, StringSize:=1) _
> _
Public Property CardType() As String
     Get
          Return Me.GetPropertyValue("CardType")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CardType", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=28, StringSize:=30) _
> _
Public Property City() As String
     Get
          Return Me.GetPropertyValue("City")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("City", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=29, StringSize:=6) _
> _
Public Property ClassId() As String
     Get
          Return Me.GetPropertyValue("ClassId")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("ClassId", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=30) _
> _
Public Property ConsolInv() As Short
     Get
          Return Me.GetPropertyValue("ConsolInv")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("ConsolInv", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=31, StringSize:=3) _
> _
Public Property Country() As String
     Get
          Return Me.GetPropertyValue("Country")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Country", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=32) _
> _
Public Property CrLmt() As Double
     Get
          Return Me.GetPropertyValue("CrLmt")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("CrLmt", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=33) _
> _
Public Property Crtd_DateTime() As Integer
     Get
          Return Me.GetPropertyValue("Crtd_DateTime")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("Crtd_DateTime", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=34, StringSize:=8) _
> _
Public Property Crtd_Prog() As String
     Get
          Return Me.GetPropertyValue("Crtd_Prog")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Crtd_Prog", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=35, StringSize:=10) _
> _
Public Property Crtd_User() As String
     Get
          Return Me.GetPropertyValue("Crtd_User")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Crtd_User", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=36, StringSize:=4) _
> _
Public Property CuryId() As String
     Get
          Return Me.GetPropertyValue("CuryId")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CuryId", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=37, StringSize:=6) _
> _
Public Property CuryPrcLvlRtTp() As String
     Get
          Return Me.GetPropertyValue("CuryPrcLvlRtTp")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CuryPrcLvlRtTp", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=38, StringSize:=6) _
> _
Public Property CuryRateType() As String
     Get
          Return Me.GetPropertyValue("CuryRateType")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CuryRateType", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=39) _
> _
Public Property CustFillPriority() As Short
     Get
          Return Me.GetPropertyValue("CustFillPriority")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("CustFillPriority", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=40, StringSize:=15) _
> _
Public Property CustId() As String
     Get
          Return Me.GetPropertyValue("CustId")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("CustId", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=41, StringSize:=10) _
> _
Public Property DfltShipToId() As String
     Get
          Return Me.GetPropertyValue("DfltShipToId")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("DfltShipToId", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=42, StringSize:=1) _
> _
Public Property DocPublishingFlag() As String
     Get
          Return Me.GetPropertyValue("DocPublishingFlag")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("DocPublishingFlag", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=43) _
> _
Public Property DunMsg() As Short
     Get
          Return Me.GetPropertyValue("DunMsg")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("DunMsg", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=44, StringSize:=80) _
> _
Public Property EMailAddr() As String
     Get
          Return Me.GetPropertyValue("EMailAddr")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("EMailAddr", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=45, StringSize:=30) _
> _
Public Property Fax() As String
     Get
          Return Me.GetPropertyValue("Fax")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Fax", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=46) _
> _
Public Property InvtSubst() As Short
     Get
          Return Me.GetPropertyValue("InvtSubst")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("InvtSubst", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=47, StringSize:=4) _
> _
Public Property LanguageID() As String
     Get
          Return Me.GetPropertyValue("LanguageID")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("LanguageID", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=48) _
> _
Public Property LUpd_DateTime() As Integer
     Get
          Return Me.GetPropertyValue("LUpd_DateTime")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("LUpd_DateTime", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=49, StringSize:=8) _
> _
Public Property LUpd_Prog() As String
     Get
          Return Me.GetPropertyValue("LUpd_Prog")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("LUpd_Prog", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=50, StringSize:=10) _
> _
Public Property LUpd_User() As String
     Get
          Return Me.GetPropertyValue("LUpd_User")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("LUpd_User", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=51, StringSize:=60) _
> _
Public Property Name() As String
     Get
          Return Me.GetPropertyValue("Name")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Name", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=52) _
> _
Public Property NoteId() As Integer
     Get
          Return Me.GetPropertyValue("NoteId")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("NoteId", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=53) _
> _
Public Property OneDraft() As Short
     Get
          Return Me.GetPropertyValue("OneDraft")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("OneDraft", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=54, StringSize:=6) _
> _
Public Property PerNbr() As String
     Get
          Return Me.GetPropertyValue("PerNbr")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("PerNbr", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=55, StringSize:=30) _
> _
Public Property Phone() As String
     Get
          Return Me.GetPropertyValue("Phone")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Phone", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=56, StringSize:=1) _
> _
Public Property PmtMethod() As String
     Get
          Return Me.GetPropertyValue("PmtMethod")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("PmtMethod", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=57, StringSize:=10) _
> _
Public Property PrcLvlId() As String
     Get
          Return Me.GetPropertyValue("PrcLvlId")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("PrcLvlId", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=58, StringSize:=10) _
> _
Public Property PrePayAcct() As String
     Get
          Return Me.GetPropertyValue("PrePayAcct")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("PrePayAcct", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=59, StringSize:=24) _
> _
Public Property PrePaySub() As String
     Get
          Return Me.GetPropertyValue("PrePaySub")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("PrePaySub", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=60, StringSize:=6) _
> _
Public Property PriceClassID() As String
     Get
          Return Me.GetPropertyValue("PriceClassID")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("PriceClassID", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=61) _
> _
Public Property PrtMCStmt() As Short
     Get
          Return Me.GetPropertyValue("PrtMCStmt")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("PrtMCStmt", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=62) _
> _
Public Property PrtStmt() As Short
     Get
          Return Me.GetPropertyValue("PrtStmt")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("PrtStmt", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=63, StringSize:=30) _
> _
Public Property S4Future01() As String
     Get
          Return Me.GetPropertyValue("S4Future01")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("S4Future01", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=64, StringSize:=30) _
> _
Public Property S4Future02() As String
     Get
          Return Me.GetPropertyValue("S4Future02")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("S4Future02", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=65) _
> _
Public Property S4Future03() As Double
     Get
          Return Me.GetPropertyValue("S4Future03")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("S4Future03", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=66) _
> _
Public Property S4Future04() As Double
     Get
          Return Me.GetPropertyValue("S4Future04")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("S4Future04", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=67) _
> _
Public Property S4Future05() As Double
     Get
          Return Me.GetPropertyValue("S4Future05")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("S4Future05", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=68) _
> _
Public Property S4Future06() As Double
     Get
          Return Me.GetPropertyValue("S4Future06")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("S4Future06", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=69) _
> _
Public Property S4Future07() As Integer
     Get
          Return Me.GetPropertyValue("S4Future07")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("S4Future07", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=70) _
> _
Public Property S4Future08() As Integer
     Get
          Return Me.GetPropertyValue("S4Future08")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("S4Future08", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=71) _
> _
Public Property S4Future09() As Integer
     Get
          Return Me.GetPropertyValue("S4Future09")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("S4Future09", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=72) _
> _
Public Property S4Future10() As Integer
     Get
          Return Me.GetPropertyValue("S4Future10")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("S4Future10", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=73, StringSize:=10) _
> _
Public Property S4Future11() As String
     Get
          Return Me.GetPropertyValue("S4Future11")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("S4Future11", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=74, StringSize:=10) _
> _
Public Property S4Future12() As String
     Get
          Return Me.GetPropertyValue("S4Future12")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("S4Future12", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=75, StringSize:=30) _
> _
Public Property Salut() As String
     Get
          Return Me.GetPropertyValue("Salut")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Salut", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=76) _
> _
Public Property SetupDate() As Integer
     Get
          Return Me.GetPropertyValue("SetupDate")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("SetupDate", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=77) _
> _
Public Property ShipCmplt() As Short
     Get
          Return Me.GetPropertyValue("ShipCmplt")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("ShipCmplt", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=78, StringSize:=1) _
> _
Public Property ShipPctAct() As String
     Get
          Return Me.GetPropertyValue("ShipPctAct")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("ShipPctAct", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=79) _
> _
Public Property ShipPctMax() As Double
     Get
          Return Me.GetPropertyValue("ShipPctMax")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("ShipPctMax", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=80, StringSize:=4) _
> _
Public Property SICCode1() As String
     Get
          Return Me.GetPropertyValue("SICCode1")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("SICCode1", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=81, StringSize:=4) _
> _
Public Property SICCode2() As String
     Get
          Return Me.GetPropertyValue("SICCode2")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("SICCode2", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=82) _
> _
Public Property SingleInvoice() As Short
     Get
          Return Me.GetPropertyValue("SingleInvoice")
     End Get
     Set(ByVal setval As Short)
          Me.SetPropertyValue("SingleInvoice", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=83, StringSize:=10) _
> _
Public Property SlsAcct() As String
     Get
          Return Me.GetPropertyValue("SlsAcct")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("SlsAcct", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=84, StringSize:=10) _
> _
Public Property SlsperId() As String
     Get
          Return Me.GetPropertyValue("SlsperId")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("SlsperId", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=85, StringSize:=24) _
> _
Public Property SlsSub() As String
     Get
          Return Me.GetPropertyValue("SlsSub")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("SlsSub", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=86, StringSize:=3) _
> _
Public Property State() As String
     Get
          Return Me.GetPropertyValue("State")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("State", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=87, StringSize:=1) _
> _
Public Property Status() As String
     Get
          Return Me.GetPropertyValue("Status")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Status", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=88, StringSize:=2) _
> _
Public Property StmtCycleId() As String
     Get
          Return Me.GetPropertyValue("StmtCycleId")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("StmtCycleId", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=89, StringSize:=1) _
> _
Public Property StmtType() As String
     Get
          Return Me.GetPropertyValue("StmtType")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("StmtType", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=90, StringSize:=1) _
> _
Public Property TaxDflt() As String
     Get
          Return Me.GetPropertyValue("TaxDflt")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("TaxDflt", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=91, StringSize:=15) _
> _
Public Property TaxExemptNbr() As String
     Get
          Return Me.GetPropertyValue("TaxExemptNbr")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("TaxExemptNbr", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=92, StringSize:=10) _
> _
Public Property TaxID00() As String
     Get
          Return Me.GetPropertyValue("TaxID00")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("TaxID00", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=93, StringSize:=10) _
> _
Public Property TaxID01() As String
     Get
          Return Me.GetPropertyValue("TaxID01")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("TaxID01", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=94, StringSize:=10) _
> _
Public Property TaxID02() As String
     Get
          Return Me.GetPropertyValue("TaxID02")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("TaxID02", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=95, StringSize:=10) _
> _
Public Property TaxID03() As String
     Get
          Return Me.GetPropertyValue("TaxID03")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("TaxID03", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=96, StringSize:=15) _
> _
Public Property TaxLocId() As String
     Get
          Return Me.GetPropertyValue("TaxLocId")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("TaxLocId", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=97, StringSize:=15) _
> _
Public Property TaxRegNbr() As String
     Get
          Return Me.GetPropertyValue("TaxRegNbr")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("TaxRegNbr", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=98, StringSize:=2) _
> _
Public Property Terms() As String
     Get
          Return Me.GetPropertyValue("Terms")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Terms", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=99, StringSize:=10) _
> _
Public Property Territory() As String
     Get
          Return Me.GetPropertyValue("Territory")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Territory", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=100) _
> _
Public Property TradeDisc() As Double
     Get
          Return Me.GetPropertyValue("TradeDisc")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("TradeDisc", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=101, StringSize:=30) _
> _
Public Property User1() As String
     Get
          Return Me.GetPropertyValue("User1")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User1", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=102, StringSize:=30) _
> _
Public Property User2() As String
     Get
          Return Me.GetPropertyValue("User2")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User2", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=103) _
> _
Public Property User3() As Double
     Get
          Return Me.GetPropertyValue("User3")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("User3", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=104) _
> _
Public Property User4() As Double
     Get
          Return Me.GetPropertyValue("User4")
     End Get
     Set(ByVal setval As Double)
          Me.SetPropertyValue("User4", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=105, StringSize:=10) _
> _
Public Property User5() As String
     Get
          Return Me.GetPropertyValue("User5")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User5", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=106, StringSize:=10) _
> _
Public Property User6() As String
     Get
          Return Me.GetPropertyValue("User6")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("User6", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=107) _
> _
Public Property User7() As Integer
     Get
          Return Me.GetPropertyValue("User7")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("User7", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=108) _
> _
Public Property User8() As Integer
     Get
          Return Me.GetPropertyValue("User8")
     End Get
     Set(ByVal setval As Integer)
          Me.SetPropertyValue("User8", setval)
     End Set
End Property
 
< _
DataBinding(PropertyIndex:=109, StringSize:=10) _
> _
Public Property Zip() As String
     Get
          Return Me.GetPropertyValue("Zip")
     End Get
     Set(ByVal setval As String)
          Me.SetPropertyValue("Zip", setval)
     End Set
End Property
 
End Class
Public bCustomer As Customer = New Customer, nCustomer As Customer = New Customer
 
Public CSR_Customer As Short
Public Sub Init_Customer(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
     Call SetAddr(x_Level, "bCustomer", bCustomer, nCustomer)
     If x_Cursor = True Then
          Call SqlCursorEx(CSR_Customer, x_Level, "CSR_Customer", "Customer", "Customer")
     End If
End Sub
 
End Module
