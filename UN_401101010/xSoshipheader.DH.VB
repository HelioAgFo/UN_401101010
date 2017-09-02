'*****************************************************************************
' <Copyright File='xsoshipheader.sdo.vb' Company='JanuSanthosh Inc'> 
' Dynamics SL - DH File Creation
' Created by D.Santhosh - SL Consultant 
' </Copyright> 
'*****************************************************************************
Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxsoshipheader
    Public Class xsoshipheader
        Inherits SolomonDataObject
        <
        DataBinding(PropertyIndex:=0)
        >
        Public Property AccrDocDate() As Integer
            Get
                Return Me.GetPropertyValue("AccrDocDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("AccrDocDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=1, StringSize:=6)
        >
        Public Property AccrPerPost() As String
            Get
                Return Me.GetPropertyValue("AccrPerPost")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("AccrPerPost", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=2, StringSize:=10)
        >
        Public Property AccrRevAcct() As String
            Get
                Return Me.GetPropertyValue("AccrRevAcct")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("AccrRevAcct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=3, StringSize:=24)
        >
        Public Property AccrRevSub() As String
            Get
                Return Me.GetPropertyValue("AccrRevSub")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("AccrRevSub", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=4, StringSize:=10)
        >
        Public Property AccrShipRegisterID() As String
            Get
                Return Me.GetPropertyValue("AccrShipRegisterID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("AccrShipRegisterID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=5, StringSize:=1)
        >
        Public Property AddressType() As String
            Get
                Return Me.GetPropertyValue("AddressType")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("AddressType", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=6)
        >
        Public Property AdminHold() As Short
            Get
                Return Me.GetPropertyValue("AdminHold")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("AdminHold", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=7, StringSize:=15)
        >
        Public Property AppliedToDocRef() As String
            Get
                Return Me.GetPropertyValue("AppliedToDocRef")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("AppliedToDocRef", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=8, StringSize:=10)
        >
        Public Property ARAcct() As String
            Get
                Return Me.GetPropertyValue("ARAcct")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ARAcct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=9, StringSize:=10)
        >
        Public Property ARBatNbr() As String
            Get
                Return Me.GetPropertyValue("ARBatNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ARBatNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=10, StringSize:=2)
        >
        Public Property ARDocType() As String
            Get
                Return Me.GetPropertyValue("ARDocType")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ARDocType", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=11, StringSize:=24)
        >
        Public Property ARSub() As String
            Get
                Return Me.GetPropertyValue("ARSub")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ARSub", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=12)
        >
        Public Property ASID() As Integer
            Get
                Return Me.GetPropertyValue("ASID")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("ASID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=13)
        >
        Public Property ASID01() As Integer
            Get
                Return Me.GetPropertyValue("ASID01")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("ASID01", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=14, StringSize:=20)
        >
        Public Property AuthNbr() As String
            Get
                Return Me.GetPropertyValue("AuthNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("AuthNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=15)
        >
        Public Property AutoReleaseReturn() As Short
            Get
                Return Me.GetPropertyValue("AutoReleaseReturn")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("AutoReleaseReturn", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=16)
        >
        Public Property BalDue() As Double
            Get
                Return Me.GetPropertyValue("BalDue")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("BalDue", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=17, StringSize:=1)
        >
        Public Property BIInvoice() As String
            Get
                Return Me.GetPropertyValue("BIInvoice")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BIInvoice", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=18, StringSize:=60)
        >
        Public Property BillAddr1() As String
            Get
                Return Me.GetPropertyValue("BillAddr1")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BillAddr1", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=19, StringSize:=60)
        >
        Public Property BillAddr2() As String
            Get
                Return Me.GetPropertyValue("BillAddr2")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BillAddr2", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=20)
        >
        Public Property BillAddrSpecial() As Short
            Get
                Return Me.GetPropertyValue("BillAddrSpecial")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("BillAddrSpecial", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=21, StringSize:=30)
        >
        Public Property BillAttn() As String
            Get
                Return Me.GetPropertyValue("BillAttn")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BillAttn", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=22, StringSize:=30)
        >
        Public Property BillCity() As String
            Get
                Return Me.GetPropertyValue("BillCity")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BillCity", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=23, StringSize:=3)
        >
        Public Property BillCountry() As String
            Get
                Return Me.GetPropertyValue("BillCountry")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BillCountry", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=24, StringSize:=60)
        >
        Public Property BillName() As String
            Get
                Return Me.GetPropertyValue("BillName")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BillName", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=25, StringSize:=30)
        >
        Public Property BillPhone() As String
            Get
                Return Me.GetPropertyValue("BillPhone")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BillPhone", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=26, StringSize:=3)
        >
        Public Property BillState() As String
            Get
                Return Me.GetPropertyValue("BillState")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BillState", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=27)
        >
        Public Property BillThruProject() As Short
            Get
                Return Me.GetPropertyValue("BillThruProject")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("BillThruProject", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=28, StringSize:=10)
        >
        Public Property BillZip() As String
            Get
                Return Me.GetPropertyValue("BillZip")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BillZip", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=29, StringSize:=15)
        >
        Public Property BlktOrdNbr() As String
            Get
                Return Me.GetPropertyValue("BlktOrdNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BlktOrdNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=30)
        >
        Public Property BMICost() As Double
            Get
                Return Me.GetPropertyValue("BMICost")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMICost", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=31, StringSize:=4)
        >
        Public Property BMICuryID() As String
            Get
                Return Me.GetPropertyValue("BMICuryID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BMICuryID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=32)
        >
        Public Property BMIEffDate() As Integer
            Get
                Return Me.GetPropertyValue("BMIEffDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("BMIEffDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=33, StringSize:=1)
        >
        Public Property BMIMultDiv() As String
            Get
                Return Me.GetPropertyValue("BMIMultDiv")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BMIMultDiv", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=34)
        >
        Public Property BMIRate() As Double
            Get
                Return Me.GetPropertyValue("BMIRate")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("BMIRate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=35, StringSize:=6)
        >
        Public Property BMIRtTp() As String
            Get
                Return Me.GetPropertyValue("BMIRtTp")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BMIRtTp", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=36)
        >
        Public Property BookCntr() As Short
            Get
                Return Me.GetPropertyValue("BookCntr")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("BookCntr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=37)
        >
        Public Property BookCntrMisc() As Integer
            Get
                Return Me.GetPropertyValue("BookCntrMisc")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("BookCntrMisc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=38)
        >
        Public Property BoxCntr() As Short
            Get
                Return Me.GetPropertyValue("BoxCntr")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("BoxCntr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=39)
        >
        Public Property BuildActQty() As Double
            Get
                Return Me.GetPropertyValue("BuildActQty")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("BuildActQty", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=40)
        >
        Public Property BuildCmpltDate() As Integer
            Get
                Return Me.GetPropertyValue("BuildCmpltDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("BuildCmpltDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=41, StringSize:=30)
        >
        Public Property BuildInvtID() As String
            Get
                Return Me.GetPropertyValue("BuildInvtID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BuildInvtID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=42)
        >
        Public Property BuildLotSerCntr() As Integer
            Get
                Return Me.GetPropertyValue("BuildLotSerCntr")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("BuildLotSerCntr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=43)
        >
        Public Property BuildQty() As Double
            Get
                Return Me.GetPropertyValue("BuildQty")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("BuildQty", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=44)
        >
        Public Property BuildTotalCost() As Double
            Get
                Return Me.GetPropertyValue("BuildTotalCost")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("BuildTotalCost", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=45, StringSize:=10)
        >
        Public Property BuyerID() As String
            Get
                Return Me.GetPropertyValue("BuyerID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BuyerID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=46, StringSize:=60)
        >
        Public Property BuyerName() As String
            Get
                Return Me.GetPropertyValue("BuyerName")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BuyerName", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=47)
        >
        Public Property CancelBO() As Short
            Get
                Return Me.GetPropertyValue("CancelBO")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("CancelBO", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=48)
        >
        Public Property Cancelled() As Short
            Get
                Return Me.GetPropertyValue("Cancelled")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("Cancelled", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=49)
        >
        Public Property CancelOrder() As Short
            Get
                Return Me.GetPropertyValue("CancelOrder")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("CancelOrder", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=50, StringSize:=2)
        >
        Public Property CertID() As String
            Get
                Return Me.GetPropertyValue("CertID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CertID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=51)
        >
        Public Property CertNoteID() As Integer
            Get
                Return Me.GetPropertyValue("CertNoteID")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("CertNoteID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=52, StringSize:=15)
        >
        Public Property ChainDisc() As String
            Get
                Return Me.GetPropertyValue("ChainDisc")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ChainDisc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=53)
        >
        Public Property CmmnPct() As Double
            Get
                Return Me.GetPropertyValue("CmmnPct")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CmmnPct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=54)
        >
        Public Property ConsolInv() As Short
            Get
                Return Me.GetPropertyValue("ConsolInv")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("ConsolInv", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=55, StringSize:=25)
        >
        Public Property ContractNbr() As String
            Get
                Return Me.GetPropertyValue("ContractNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ContractNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=56, StringSize:=10)
        >
        Public Property CpnyID() As String
            Get
                Return Me.GetPropertyValue("CpnyID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CpnyID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=57)
        >
        Public Property CreditApprDays() As Short
            Get
                Return Me.GetPropertyValue("CreditApprDays")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("CreditApprDays", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=58)
        >
        Public Property CreditApprLimit() As Double
            Get
                Return Me.GetPropertyValue("CreditApprLimit")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CreditApprLimit", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=59)
        >
        Public Property CreditChk() As Short
            Get
                Return Me.GetPropertyValue("CreditChk")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("CreditChk", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=60)
        >
        Public Property CreditHold() As Short
            Get
                Return Me.GetPropertyValue("CreditHold")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("CreditHold", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=61)
        >
        Public Property CreditHoldDate() As Integer
            Get
                Return Me.GetPropertyValue("CreditHoldDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("CreditHoldDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=62)
        >
        Public Property Crtd_DateTime() As Integer
            Get
                Return Me.GetPropertyValue("Crtd_DateTime")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("Crtd_DateTime", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=63, StringSize:=8)
        >
        Public Property Crtd_Prog() As String
            Get
                Return Me.GetPropertyValue("Crtd_Prog")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Crtd_Prog", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=64, StringSize:=10)
        >
        Public Property Crtd_User() As String
            Get
                Return Me.GetPropertyValue("Crtd_User")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Crtd_User", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=65)
        >
        Public Property CuryBalDue() As Double
            Get
                Return Me.GetPropertyValue("CuryBalDue")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryBalDue", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=66)
        >
        Public Property CuryBuildTotCost() As Double
            Get
                Return Me.GetPropertyValue("CuryBuildTotCost")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryBuildTotCost", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=67)
        >
        Public Property CuryEffDate() As Integer
            Get
                Return Me.GetPropertyValue("CuryEffDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("CuryEffDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=68, StringSize:=4)
        >
        Public Property CuryID() As String
            Get
                Return Me.GetPropertyValue("CuryID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CuryID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=69, StringSize:=1)
        >
        Public Property CuryMultDiv() As String
            Get
                Return Me.GetPropertyValue("CuryMultDiv")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CuryMultDiv", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=70)
        >
        Public Property CuryPremFrtAmt() As Double
            Get
                Return Me.GetPropertyValue("CuryPremFrtAmt")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryPremFrtAmt", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=71)
        >
        Public Property CuryRate() As Double
            Get
                Return Me.GetPropertyValue("CuryRate")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryRate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=72, StringSize:=6)
        >
        Public Property CuryRateType() As String
            Get
                Return Me.GetPropertyValue("CuryRateType")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CuryRateType", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=73)
        >
        Public Property CuryTotFrtCost() As Double
            Get
                Return Me.GetPropertyValue("CuryTotFrtCost")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryTotFrtCost", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=74)
        >
        Public Property CuryTotFrtInvc() As Double
            Get
                Return Me.GetPropertyValue("CuryTotFrtInvc")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryTotFrtInvc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=75)
        >
        Public Property CuryTotInvc() As Double
            Get
                Return Me.GetPropertyValue("CuryTotInvc")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryTotInvc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=76)
        >
        Public Property CuryTotLineDisc() As Double
            Get
                Return Me.GetPropertyValue("CuryTotLineDisc")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryTotLineDisc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=77)
        >
        Public Property CuryTotMerch() As Double
            Get
                Return Me.GetPropertyValue("CuryTotMerch")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryTotMerch", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=78)
        >
        Public Property CuryTotMisc() As Double
            Get
                Return Me.GetPropertyValue("CuryTotMisc")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryTotMisc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=79)
        >
        Public Property CuryTotPmt() As Double
            Get
                Return Me.GetPropertyValue("CuryTotPmt")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryTotPmt", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=80)
        >
        Public Property CuryTotTax() As Double
            Get
                Return Me.GetPropertyValue("CuryTotTax")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryTotTax", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=81)
        >
        Public Property CuryTotTxbl() As Double
            Get
                Return Me.GetPropertyValue("CuryTotTxbl")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryTotTxbl", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=82)
        >
        Public Property CuryWholeOrdDisc() As Double
            Get
                Return Me.GetPropertyValue("CuryWholeOrdDisc")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("CuryWholeOrdDisc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=83, StringSize:=4)
        >
        Public Property CustGLClassID() As String
            Get
                Return Me.GetPropertyValue("CustGLClassID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CustGLClassID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=84, StringSize:=15)
        >
        Public Property CustID() As String
            Get
                Return Me.GetPropertyValue("CustID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CustID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=85, StringSize:=25)
        >
        Public Property CustOrdNbr() As String
            Get
                Return Me.GetPropertyValue("CustOrdNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CustOrdNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=86)
        >
        Public Property DateCancelled() As Integer
            Get
                Return Me.GetPropertyValue("DateCancelled")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("DateCancelled", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=87, StringSize:=30)
        >
        Public Property Dept() As String
            Get
                Return Me.GetPropertyValue("Dept")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Dept", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=88, StringSize:=10)
        >
        Public Property DiscAcct() As String
            Get
                Return Me.GetPropertyValue("DiscAcct")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("DiscAcct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=89)
        >
        Public Property DiscPct() As Double
            Get
                Return Me.GetPropertyValue("DiscPct")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("DiscPct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=90, StringSize:=24)
        >
        Public Property DiscSub() As String
            Get
                Return Me.GetPropertyValue("DiscSub")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("DiscSub", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=91, StringSize:=30)
        >
        Public Property Div() As String
            Get
                Return Me.GetPropertyValue("Div")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Div", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=92)
        >
        Public Property DropShip() As Short
            Get
                Return Me.GetPropertyValue("DropShip")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("DropShip", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=93)
        >
        Public Property EDI810() As Short
            Get
                Return Me.GetPropertyValue("EDI810")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("EDI810", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=94)
        >
        Public Property EDI856() As Short
            Get
                Return Me.GetPropertyValue("EDI856")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("EDI856", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=95, StringSize:=10)
        >
        Public Property EDIASNProcNbr() As String
            Get
                Return Me.GetPropertyValue("EDIASNProcNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("EDIASNProcNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=96, StringSize:=10)
        >
        Public Property EDIInvcProcNbr() As String
            Get
                Return Me.GetPropertyValue("EDIInvcProcNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("EDIInvcProcNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=97)
        >
        Public Property ETADate() As Integer
            Get
                Return Me.GetPropertyValue("ETADate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("ETADate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=98, StringSize:=15)
        >
        Public Property FOBID() As String
            Get
                Return Me.GetPropertyValue("FOBID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("FOBID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=99, StringSize:=10)
        >
        Public Property FrtAcct() As String
            Get
                Return Me.GetPropertyValue("FrtAcct")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("FrtAcct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=100)
        >
        Public Property FrtCollect() As Short
            Get
                Return Me.GetPropertyValue("FrtCollect")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("FrtCollect", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=101, StringSize:=24)
        >
        Public Property FrtSub() As String
            Get
                Return Me.GetPropertyValue("FrtSub")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("FrtSub", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=102, StringSize:=10)
        >
        Public Property FrtTermsID() As String
            Get
                Return Me.GetPropertyValue("FrtTermsID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("FrtTermsID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=103, StringSize:=10)
        >
        Public Property GeoCode() As String
            Get
                Return Me.GetPropertyValue("GeoCode")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("GeoCode", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=104, StringSize:=10)
        >
        Public Property INBatNbr() As String
            Get
                Return Me.GetPropertyValue("INBatNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("INBatNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=105)
        >
        Public Property InvcDate() As Integer
            Get
                Return Me.GetPropertyValue("InvcDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("InvcDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=106, StringSize:=15)
        >
        Public Property InvcNbr() As String
            Get
                Return Me.GetPropertyValue("InvcNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("InvcNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=107)
        >
        Public Property InvcPrint() As Short
            Get
                Return Me.GetPropertyValue("InvcPrint")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("InvcPrint", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=108, StringSize:=4)
        >
        Public Property LanguageID() As String
            Get
                Return Me.GetPropertyValue("LanguageID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("LanguageID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=109)
        >
        Public Property LastAppendDate() As Integer
            Get
                Return Me.GetPropertyValue("LastAppendDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("LastAppendDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=110)
        >
        Public Property LastAppendTime() As Integer
            Get
                Return Me.GetPropertyValue("LastAppendTime")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("LastAppendTime", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=111)
        >
        Public Property LineCntr() As Short
            Get
                Return Me.GetPropertyValue("LineCntr")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("LineCntr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=112)
        >
        Public Property LotSerialHold() As Short
            Get
                Return Me.GetPropertyValue("LotSerialHold")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("LotSerialHold", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=113)
        >
        Public Property LUpd_DateTime() As Integer
            Get
                Return Me.GetPropertyValue("LUpd_DateTime")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("LUpd_DateTime", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=114, StringSize:=8)
        >
        Public Property LUpd_Prog() As String
            Get
                Return Me.GetPropertyValue("LUpd_Prog")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("LUpd_Prog", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=115, StringSize:=10)
        >
        Public Property LUpd_User() As String
            Get
                Return Me.GetPropertyValue("LUpd_User")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("LUpd_User", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=116)
        >
        Public Property MarkFor() As Short
            Get
                Return Me.GetPropertyValue("MarkFor")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("MarkFor", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=117)
        >
        Public Property MiscChrgCntr() As Short
            Get
                Return Me.GetPropertyValue("MiscChrgCntr")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("MiscChrgCntr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=118, StringSize:=4)
        >
        Public Property NextFunctionClass() As String
            Get
                Return Me.GetPropertyValue("NextFunctionClass")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("NextFunctionClass", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=119, StringSize:=8)
        >
        Public Property NextFunctionID() As String
            Get
                Return Me.GetPropertyValue("NextFunctionID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("NextFunctionID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=120)
        >
        Public Property NoteID() As Integer
            Get
                Return Me.GetPropertyValue("NoteID")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("NoteID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=121)
        >
        Public Property OKToAppend() As Short
            Get
                Return Me.GetPropertyValue("OKToAppend")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("OKToAppend", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=122)
        >
        Public Property OrdDate() As Integer
            Get
                Return Me.GetPropertyValue("OrdDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("OrdDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=123, StringSize:=15)
        >
        Public Property OrdNbr() As String
            Get
                Return Me.GetPropertyValue("OrdNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("OrdNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=124)
        >
        Public Property OverridePerPost() As Short
            Get
                Return Me.GetPropertyValue("OverridePerPost")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("OverridePerPost", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=125)
        >
        Public Property PackDate() As Integer
            Get
                Return Me.GetPropertyValue("PackDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("PackDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=126, StringSize:=6)
        >
        Public Property PerClosed() As String
            Get
                Return Me.GetPropertyValue("PerClosed")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("PerClosed", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=127, StringSize:=6)
        >
        Public Property PerPost() As String
            Get
                Return Me.GetPropertyValue("PerPost")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("PerPost", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=128)
        >
        Public Property PickDate() As Integer
            Get
                Return Me.GetPropertyValue("PickDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("PickDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=129)
        >
        Public Property PmtCntr() As Short
            Get
                Return Me.GetPropertyValue("PmtCntr")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("PmtCntr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=130)
        >
        Public Property PremFrt() As Short
            Get
                Return Me.GetPropertyValue("PremFrt")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("PremFrt", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=131)
        >
        Public Property PremFrtAmt() As Double
            Get
                Return Me.GetPropertyValue("PremFrtAmt")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("PremFrtAmt", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=132)
        >
        Public Property Priority() As Short
            Get
                Return Me.GetPropertyValue("Priority")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("Priority", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=133, StringSize:=16)
        >
        Public Property ProjectID() As String
            Get
                Return Me.GetPropertyValue("ProjectID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ProjectID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=134)
        >
        Public Property RelDate() As Integer
            Get
                Return Me.GetPropertyValue("RelDate")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("RelDate", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=135)
        >
        Public Property ReleaseValue() As Double
            Get
                Return Me.GetPropertyValue("ReleaseValue")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("ReleaseValue", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=136)
        >
        Public Property RequireStepAssy() As Short
            Get
                Return Me.GetPropertyValue("RequireStepAssy")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("RequireStepAssy", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=137)
        >
        Public Property RequireStepInsp() As Short
            Get
                Return Me.GetPropertyValue("RequireStepInsp")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("RequireStepInsp", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=138, StringSize:=30)
        >
        Public Property S4Future01() As String
            Get
                Return Me.GetPropertyValue("S4Future01")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future01", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=139, StringSize:=30)
        >
        Public Property S4Future02() As String
            Get
                Return Me.GetPropertyValue("S4Future02")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future02", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=140)
        >
        Public Property S4Future03() As Double
            Get
                Return Me.GetPropertyValue("S4Future03")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future03", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=141)
        >
        Public Property S4Future04() As Double
            Get
                Return Me.GetPropertyValue("S4Future04")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future04", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=142)
        >
        Public Property S4Future05() As Double
            Get
                Return Me.GetPropertyValue("S4Future05")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future05", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=143)
        >
        Public Property S4Future06() As Double
            Get
                Return Me.GetPropertyValue("S4Future06")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("S4Future06", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=144)
        >
        Public Property S4Future07() As Integer
            Get
                Return Me.GetPropertyValue("S4Future07")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future07", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=145)
        >
        Public Property S4Future08() As Integer
            Get
                Return Me.GetPropertyValue("S4Future08")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future08", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=146)
        >
        Public Property S4Future09() As Integer
            Get
                Return Me.GetPropertyValue("S4Future09")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future09", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=147)
        >
        Public Property S4Future10() As Integer
            Get
                Return Me.GetPropertyValue("S4Future10")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("S4Future10", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=148, StringSize:=10)
        >
        Public Property S4Future11() As String
            Get
                Return Me.GetPropertyValue("S4Future11")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future11", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=149, StringSize:=10)
        >
        Public Property S4Future12() As String
            Get
                Return Me.GetPropertyValue("S4Future12")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("S4Future12", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=150, StringSize:=10)
        >
        Public Property SellingSiteID() As String
            Get
                Return Me.GetPropertyValue("SellingSiteID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("SellingSiteID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=151, StringSize:=60)
        >
        Public Property ShipAddr1() As String
            Get
                Return Me.GetPropertyValue("ShipAddr1")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipAddr1", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=152, StringSize:=60)
        >
        Public Property ShipAddr2() As String
            Get
                Return Me.GetPropertyValue("ShipAddr2")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipAddr2", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=153, StringSize:=10)
        >
        Public Property ShipAddrID() As String
            Get
                Return Me.GetPropertyValue("ShipAddrID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipAddrID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=154)
        >
        Public Property ShipAddrSpecial() As Short
            Get
                Return Me.GetPropertyValue("ShipAddrSpecial")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("ShipAddrSpecial", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=155, StringSize:=30)
        >
        Public Property ShipAttn() As String
            Get
                Return Me.GetPropertyValue("ShipAttn")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipAttn", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=156, StringSize:=30)
        >
        Public Property ShipCity() As String
            Get
                Return Me.GetPropertyValue("ShipCity")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipCity", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=157)
        >
        Public Property ShipCmplt() As Short
            Get
                Return Me.GetPropertyValue("ShipCmplt")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("ShipCmplt", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=158, StringSize:=3)
        >
        Public Property ShipCountry() As String
            Get
                Return Me.GetPropertyValue("ShipCountry")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipCountry", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=159, StringSize:=15)
        >
        Public Property ShipCustID() As String
            Get
                Return Me.GetPropertyValue("ShipCustID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipCustID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=160)
        >
        Public Property ShipDateAct() As Integer
            Get
                Return Me.GetPropertyValue("ShipDateAct")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("ShipDateAct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=161)
        >
        Public Property ShipDatePlan() As Integer
            Get
                Return Me.GetPropertyValue("ShipDatePlan")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("ShipDatePlan", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=162, StringSize:=10)
        >
        Public Property ShipGeoCode() As String
            Get
                Return Me.GetPropertyValue("ShipGeoCode")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipGeoCode", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=163, StringSize:=60)
        >
        Public Property ShipName() As String
            Get
                Return Me.GetPropertyValue("ShipName")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipName", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=164, StringSize:=15)
        >
        Public Property ShipperID() As String
            Get
                Return Me.GetPropertyValue("ShipperID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipperID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=165, StringSize:=30)
        >
        Public Property ShipPhone() As String
            Get
                Return Me.GetPropertyValue("ShipPhone")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipPhone", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=166)
        >
        Public Property ShippingConfirmed() As Short
            Get
                Return Me.GetPropertyValue("ShippingConfirmed")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("ShippingConfirmed", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=167)
        >
        Public Property ShippingManifested() As Short
            Get
                Return Me.GetPropertyValue("ShippingManifested")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("ShippingManifested", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=168, StringSize:=10)
        >
        Public Property ShipRegisterID() As String
            Get
                Return Me.GetPropertyValue("ShipRegisterID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipRegisterID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=169, StringSize:=10)
        >
        Public Property ShipSiteID() As String
            Get
                Return Me.GetPropertyValue("ShipSiteID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipSiteID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=170, StringSize:=3)
        >
        Public Property ShipState() As String
            Get
                Return Me.GetPropertyValue("ShipState")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipState", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=171, StringSize:=10)
        >
        Public Property ShiptoID() As String
            Get
                Return Me.GetPropertyValue("ShiptoID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShiptoID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=172, StringSize:=1)
        >
        Public Property ShiptoType() As String
            Get
                Return Me.GetPropertyValue("ShiptoType")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShiptoType", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=173, StringSize:=10)
        >
        Public Property ShipVendAddrID() As String
            Get
                Return Me.GetPropertyValue("ShipVendAddrID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipVendAddrID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=174, StringSize:=15)
        >
        Public Property ShipVendID() As String
            Get
                Return Me.GetPropertyValue("ShipVendID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipVendID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=175, StringSize:=15)
        >
        Public Property ShipViaID() As String
            Get
                Return Me.GetPropertyValue("ShipViaID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipViaID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=176, StringSize:=10)
        >
        Public Property ShipZip() As String
            Get
                Return Me.GetPropertyValue("ShipZip")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipZip", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=177, StringSize:=10)
        >
        Public Property SiteID() As String
            Get
                Return Me.GetPropertyValue("SiteID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("SiteID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=178, StringSize:=10)
        >
        Public Property SlsperID() As String
            Get
                Return Me.GetPropertyValue("SlsperID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("SlsperID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=179, StringSize:=4)
        >
        Public Property SOTypeID() As String
            Get
                Return Me.GetPropertyValue("SOTypeID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("SOTypeID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=180, StringSize:=1)
        >
        Public Property Status() As String
            Get
                Return Me.GetPropertyValue("Status")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Status", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=181, StringSize:=10)
        >
        Public Property TaxID00() As String
            Get
                Return Me.GetPropertyValue("TaxID00")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxID00", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=182, StringSize:=10)
        >
        Public Property TaxID01() As String
            Get
                Return Me.GetPropertyValue("TaxID01")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxID01", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=183, StringSize:=10)
        >
        Public Property TaxID02() As String
            Get
                Return Me.GetPropertyValue("TaxID02")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxID02", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=184, StringSize:=10)
        >
        Public Property TaxID03() As String
            Get
                Return Me.GetPropertyValue("TaxID03")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxID03", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=185, StringSize:=2)
        >
        Public Property TermsID() As String
            Get
                Return Me.GetPropertyValue("TermsID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TermsID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=186)
        >
        Public Property TotBoxes() As Short
            Get
                Return Me.GetPropertyValue("TotBoxes")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("TotBoxes", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=187)
        >
        Public Property TotCommCost() As Double
            Get
                Return Me.GetPropertyValue("TotCommCost")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotCommCost", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=188)
        >
        Public Property TotCost() As Double
            Get
                Return Me.GetPropertyValue("TotCost")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotCost", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=189)
        >
        Public Property TotFrtCost() As Double
            Get
                Return Me.GetPropertyValue("TotFrtCost")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotFrtCost", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=190)
        >
        Public Property TotFrtInvc() As Double
            Get
                Return Me.GetPropertyValue("TotFrtInvc")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotFrtInvc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=191)
        >
        Public Property TotInvc() As Double
            Get
                Return Me.GetPropertyValue("TotInvc")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotInvc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=192)
        >
        Public Property TotLineDisc() As Double
            Get
                Return Me.GetPropertyValue("TotLineDisc")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotLineDisc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=193)
        >
        Public Property TotMerch() As Double
            Get
                Return Me.GetPropertyValue("TotMerch")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotMerch", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=194)
        >
        Public Property TotMisc() As Double
            Get
                Return Me.GetPropertyValue("TotMisc")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotMisc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=195)
        >
        Public Property TotPallets() As Short
            Get
                Return Me.GetPropertyValue("TotPallets")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("TotPallets", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=196)
        >
        Public Property TotPmt() As Double
            Get
                Return Me.GetPropertyValue("TotPmt")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotPmt", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=197)
        >
        Public Property TotShipWght() As Double
            Get
                Return Me.GetPropertyValue("TotShipWght")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotShipWght", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=198)
        >
        Public Property TotTax() As Double
            Get
                Return Me.GetPropertyValue("TotTax")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotTax", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=199)
        >
        Public Property TotTxbl() As Double
            Get
                Return Me.GetPropertyValue("TotTxbl")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("TotTxbl", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=200, StringSize:=25)
        >
        Public Property TrackingNbr() As String
            Get
                Return Me.GetPropertyValue("TrackingNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TrackingNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=201)
        >
        Public Property TransitTime() As Short
            Get
                Return Me.GetPropertyValue("TransitTime")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("TransitTime", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=202, StringSize:=30)
        >
        Public Property User1() As String
            Get
                Return Me.GetPropertyValue("User1")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User1", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=203)
        >
        Public Property User10() As Integer
            Get
                Return Me.GetPropertyValue("User10")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User10", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=204, StringSize:=30)
        >
        Public Property User2() As String
            Get
                Return Me.GetPropertyValue("User2")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User2", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=205, StringSize:=30)
        >
        Public Property User3() As String
            Get
                Return Me.GetPropertyValue("User3")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User3", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=206, StringSize:=30)
        >
        Public Property User4() As String
            Get
                Return Me.GetPropertyValue("User4")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User4", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=207)
        >
        Public Property User5() As Double
            Get
                Return Me.GetPropertyValue("User5")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("User5", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=208)
        >
        Public Property User6() As Double
            Get
                Return Me.GetPropertyValue("User6")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("User6", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=209, StringSize:=10)
        >
        Public Property User7() As String
            Get
                Return Me.GetPropertyValue("User7")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User7", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=210, StringSize:=10)
        >
        Public Property User8() As String
            Get
                Return Me.GetPropertyValue("User8")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User8", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=211)
        >
        Public Property User9() As Integer
            Get
                Return Me.GetPropertyValue("User9")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User9", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=212)
        >
        Public Property WeekendDelivery() As Short
            Get
                Return Me.GetPropertyValue("WeekendDelivery")
            End Get
            Set(ByVal setval As Short)
                Me.SetPropertyValue("WeekendDelivery", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=213)
        >
        Public Property WholeOrdDisc() As Double
            Get
                Return Me.GetPropertyValue("WholeOrdDisc")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("WholeOrdDisc", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=214)
        >
        Public Property WorkflowID() As Integer
            Get
                Return Me.GetPropertyValue("WorkflowID")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("WorkflowID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=215, StringSize:=1)
        >
        Public Property WorkflowStatus() As String
            Get
                Return Me.GetPropertyValue("WorkflowStatus")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("WorkflowStatus", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=216)
        >
        Public Property WSID() As Integer
            Get
                Return Me.GetPropertyValue("WSID")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("WSID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=217)
        >
        Public Property WSID01() As Integer
            Get
                Return Me.GetPropertyValue("WSID01")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("WSID01", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=218, StringSize:=6)
        >
        Public Property Zone() As String
            Get
                Return Me.GetPropertyValue("Zone")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Zone", setval)
            End Set
        End Property

    End Class
    Public bxSOShipHeader As xsoshipheader = New xsoshipheader, nxSOShipHeader As xsoshipheader = New xsoshipheader

    Public CSR_xSOShipHeader As Short
    Public Sub Init_xSOShipHeader(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
        Call SetAddr(x_Level, "bxSOShipHeader", bxSOShipHeader, nxSOShipHeader)
        If x_Cursor = True Then
            Call SqlCursorEx(CSR_xSOShipHeader, x_Level, "CSR_xSOShipHeader", "xSOShipHeader", "xSOShipHeader")
        End If
    End Sub

End Module
