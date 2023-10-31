

------------------------------ Model Changle from all Table --------------------------------------------------------
Create proc spUpdatetblMasterDetails
(
@MDID int,
@ChallanNo nvarchar(100),
@Brand nvarchar(50),
@Category nvarchar(50),
@ProductName nvarchar(50),
@Model nvarchar(50),
@Serial nvarchar(50),
@Code nvarchar(50),  -- define Localtion frmUpdateDetails in app
@ReceiveChallan nvarchar(50),

@PreviousChallanno nvarchar(100),
@PreviousModel nvarchar(50),
@PreviousSerial nvarchar(50)

)
as
begin
begin try
begin transaction
update tblMasterDetails set ChallanNo=@ChallanNo, Brand=@Brand, Category=@Category, 
ProductName=@ProductName, Model=@Model, Serial=@Serial, Code=@Code, ReceiveChallan=@ReceiveChallan
where MDID=@MDID
update tblCannibalized set ChallanNo=@ChallanNo, Model=@Model, Serial=@Serial
where ChallanNo=@PreviousChallanno and Model=@PreviousModel and Serial=@PreviousSerial
update tblNotReturn set Model=@Model, Serial=@Serial, ChallanNo=@ChallanNo
where Model=@PreviousModel and Serial=@PreviousSerial and ChallanNo=@PreviousChallanno 


commit transaction

end try

begin catch

rollback transaction

end catch

end

go
create proc spGettblMasterDetails_by_Challan_Model_Serial
(
@ChallanNo nvarchar(100),
@Model nvarchar(50),
@Serial nvarchar(50)
)
as
begin
Select * from tblMasterDetails where ChallanNo=@ChallanNo and Model=@Model and Serial=@Serial
end

go
Create proc SpChangeChallanNo
(
@PreviousChallan nvarchar(100),
@NewChallan nvarchar(100)
)
as
begin


begin try

begin transaction


update tblMaster set ChallanNo=@NewChallan where ChallanNo=@PreviousChallan
update tblMasterDetails set ChallanNo=@NewChallan where ChallanNo=@PreviousChallan
update tblMasterDetails set ReceiveChallan=@NewChallan where ReceiveChallan=@PreviousChallan
update tblCannibalized set ChallanNo=@NewChallan where ChallanNo=@PreviousChallan
update tblNotReturn set ChallanNo=@NewChallan where ChallanNo=@PreviousChallan



commit transaction

end try

begin catch

declare @errmsg nvarchar(100)
declare @errsevr nvarchar(100)
declare @errstatus nvarchar(100)

select @errmsg=ERROR_MESSAGE(), @errsevr=ERROR_SEVERITY(),@errstatus=ERROR_STATE()
rollback transaction
RAISERROR(@errmsg,@errsevr,@errstatus)

end catch




end

go 
Create proc sptblMasterGetAll
as
begin
Select  * from tblMaster
end

go

ALTER proc [dbo].[sptblCannibalized_UniqueModelAll]
(
@Brand nvarchar(50)=null,
@Category nvarchar(50)=null
)
as

begin
select distinct tblCannibalized.ChallanNo, tblCannibalized.Model, tblCannibalized.Serial,tblMasterDetails.Code from tblCannibalized inner join tblMasterDetails on tblCannibalized.ChallanNo=tblMasterDetails.ChallanNo 
and tblCannibalized.Model=tblMasterDetails.Model and tblCannibalized.Serial=tblMasterDetails.Serial
where (tblMasterDetails.Brand=@Brand or @Brand is null) and (tblMasterDetails.Category=@Category or @Category is null)
end


go

ALTER proc [dbo].[sptblCannibalized_UniqueModel_by_Date](
@startDate nvarchar(25),
@EndDate nvarchar(25),
@Brand nvarchar(50)=null,
@Category nvarchar(50)=null
)
as
begin
select distinct tblCannibalized.ChallanNo, tblCannibalized.Model, 
tblCannibalized.Serial,tblMasterDetails.Code from tblCannibalized inner join tblMasterDetails on tblCannibalized.ChallanNo=tblMasterDetails.ChallanNo 
and tblCannibalized.Model=tblMasterDetails.Model and tblCannibalized.Serial=tblMasterDetails.Serial
where tblCannibalized.ReceivedDate between @startDate and @EndDate and(tblMasterDetails.Brand=@Brand or @Brand is null) and (tblMasterDetails.Category=@Category or @Category is null)
end

go
ALTER proc [dbo].[sptblCannibalized_GetAll]
(
@Brand nvarchar(50)=null,
@Category nvarchar(50)=null

)
as
begin
--it is using on frmCannibalizedProductInformation for Details for All Record

Select  
tblCannibalized.CanID,tblCannibalized.ChallanNo,tblCannibalized.Model,tblCannibalized.Serial,
tblCannibalized.Serial,tblMasterDetails.Code,tblCannibalized.ReceivedDate,tblCannibalized.ProductName,
tblCannibalized.PartNo,tblCannibalized.Branch,tblCannibalized.JobCode,tblCannibalized.[Status],
tblCannibalized.OrderQty,tblCannibalized.OrderDate,tblCannibalized.Accessories
from tblCannibalized  inner join tblMasterDetails on tblCannibalized.ChallanNo=tblMasterDetails.ChallanNo 
and tblCannibalized.Model=tblMasterDetails.Model and tblCannibalized.Serial=tblMasterDetails.Serial
where (tblMasterDetails.Brand=@Brand or @Brand is null) and (tblMasterDetails.Category=@Category or @Category is null)
end




go
ALTER proc [dbo].[sptblCannibalized_byReceiveDate]
(
@startDate nvarchar(25),
@EndDate nvarchar(25),
@Brand nvarchar(50)=null,
@Category nvarchar(50)=null
)
as
begin

Select  
tblCannibalized.CanID,tblCannibalized.ChallanNo,tblCannibalized.Model,tblCannibalized.Serial,
tblCannibalized.Serial,tblMasterDetails.Code,tblCannibalized.ReceivedDate,tblCannibalized.ProductName,
tblCannibalized.PartNo,tblCannibalized.Branch,tblCannibalized.JobCode,tblCannibalized.[Status],
tblCannibalized.OrderQty,tblCannibalized.OrderDate,tblCannibalized.Accessories
from tblCannibalized  inner join tblMasterDetails on tblCannibalized.ChallanNo=tblMasterDetails.ChallanNo 
and tblCannibalized.Model=tblMasterDetails.Model and tblCannibalized.Serial=tblMasterDetails.Serial
where (tblMasterDetails.Brand=@Brand or @Brand is null) and (tblMasterDetails.Category=@Category or @Category is null) and tblCannibalized.ReceivedDate between @startDate and @EndDate
end






go
ALTER proc [dbo].[spGetModelDetails_byReceive]
(
@Model nvarchar(50)=null
)
as
begin

set nocount on
select  m.ReceiveChallan, m.Brand,m.Category,m.ProductName,m.Code, m.Model,m.Serial,m.ReceiveDate,m.DeliveryDate,m.DeliveryChallan,m.[Source],m.Destination,m.Condition,m.Remarks,nonr.NonReturn,nonr.NrReason from (select Main.ReceiveChallan, Main.Brand,Main.Category,Main.ProductName,Main.Code, Main.Model,Main.Serial,main.[Receive] as ReceiveDate,Main.Delivery as DeliveryDate,main.DeliveryChallan,Main.[Source],Main.Destination,Main.ReceiveCondition as Condition,Main.Remarks From 
(select rec.ChallanNo as ReceiveChallan, rec.Brand,rec.Category,rec.ProductName,rec.Code, rec.Model,rec.Serial,rec.TrDate as [Receive],del.TrDate as Delivery,del.ChallanNo as DeliveryChallan,rec.[Source],rec.Destination,rec.ReceiveCondition,rec.Remarks  from 
(select tblMaster.ChallanNo, tblMasterDetails.Brand,tblMasterDetails.Category,tblMasterDetails.ProductName,tblMasterDetails.Code, tblMasterDetails.Model, tblMasterDetails.Serial,tblMaster.TrDate,tblMaster.[Source],tblMaster.Destination,tblMaster.ReceiveCondition,tblMaster.Remarks
from tblMasterDetails inner join tblMaster on tblMasterDetails.ChallanNo=tblMaster.ChallanNo 
where tblMaster.TrType='Receive') 
as rec left join (select tblMaster.ChallanNo, tblMasterDetails.Model, tblMasterDetails.Serial,tblMaster.TrDate,tblmasterdetails.ReceiveChallan
from tblMasterDetails inner join tblMaster on tblMasterDetails.ChallanNo=tblMaster.ChallanNo 
where tblMaster.TrType='Delivery') as del on rec.Model=del.Model and rec.Serial=del.Serial and rec.ChallanNo=del.ReceiveChallan) as 
Main) as m left join(Select tblNotReturn.Model,tblNotReturn.Serial,tblNotReturn.ChallanNo,tblNotReturn.NrReason, 'Not Returnable' as NonReturn from tblNotReturn) as nonr on m.Model=nonr.Model and m.Serial=nonr.Serial and m.ReceiveChallan=nonr.ChallanNo
where (m.Model=@Model or @Model is null)
end

go
ALTER proc [dbo].[spGetModelDetails_byReceive]
(
@Model nvarchar(50)=null
)
as
begin

set nocount on
select  m.ReceiveChallan, m.Brand,m.Category,m.ProductName,m.Code, m.Model,m.Serial,m.ReceiveDate,m.DeliveryDate,m.DeliveryChallan,m.[Source],m.Destination,m.Condition,m.Remarks,nonr.NonReturn,nonr.NrReason from (select Main.ReceiveChallan, Main.Brand,Main.Category,Main.ProductName,Main.Code, Main.Model,Main.Serial,main.[Receive] as ReceiveDate,Main.Delivery as DeliveryDate,main.DeliveryChallan,Main.[Source],Main.Destination,Main.ReceiveCondition as Condition,Main.Remarks From 
(select rec.ChallanNo as ReceiveChallan, rec.Brand,rec.Category,rec.ProductName,rec.Code, rec.Model,rec.Serial,rec.TrDate as [Receive],del.TrDate as Delivery,del.ChallanNo as DeliveryChallan,rec.[Source],rec.Destination,rec.ReceiveCondition,rec.Remarks  from 
(select tblMaster.ChallanNo, tblMasterDetails.Brand,tblMasterDetails.Category,tblMasterDetails.ProductName,tblMasterDetails.Code, tblMasterDetails.Model, tblMasterDetails.Serial,tblMaster.TrDate,tblMaster.[Source],tblMaster.Destination,tblMaster.ReceiveCondition,tblMaster.Remarks
from tblMasterDetails inner join tblMaster on tblMasterDetails.ChallanNo=tblMaster.ChallanNo 
where tblMaster.TrType='Receive') 
as rec left join (select tblMaster.ChallanNo, tblMasterDetails.Model, tblMasterDetails.Serial,tblMaster.TrDate,tblmasterdetails.ReceiveChallan
from tblMasterDetails inner join tblMaster on tblMasterDetails.ChallanNo=tblMaster.ChallanNo 
where tblMaster.TrType='Delivery') as del on rec.Model=del.Model and rec.Serial=del.Serial and rec.ChallanNo=del.ReceiveChallan) as 
Main) as m left join(Select tblNotReturn.Model,tblNotReturn.Serial,tblNotReturn.ChallanNo,tblNotReturn.NrReason, 'Not Returnable' as NonReturn from tblNotReturn) as nonr on m.Model=nonr.Model and m.Serial=nonr.Serial and m.ReceiveChallan=nonr.ChallanNo
where (m.Model=@Model or @Model is null)
end
go
ALTER proc [dbo].[spCannibalized_Get_By_ModelSerial]
(
@Model nvarchar(50),
@Serial nvarchar(50),
@ChallanNo nvarchar(100)

)

as
begin
select * from tblCannibalized where (Model=@Model or @Model is null) and (Serial=@Serial or @Serial is null) and (ChallanNo=@ChallanNo or @ChallanNo is null)

end