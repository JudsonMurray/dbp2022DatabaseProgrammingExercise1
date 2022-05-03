USE Northwind ;
GO

--SELECT * FROM Northwind.dbo.Shippers ;
SELECT * FROM Shippers ;

SELECT * FROM Employees ;


SELECT * FROM  
(
	SELECT 
		*,
		InvoiceTotal-CreditTotal-PaymentTotal AS PaidAmount
	FROM AP.dbo.Invoices
) AS InvoiceInfo ;


SELECT * FROM Shippers ORDER BY "ShipperID" DESC 