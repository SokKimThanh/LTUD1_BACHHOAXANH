-- Stored procedure for 'Create'
go 
CREATE PROCEDURE sp_CreateAccount(@p_username VARCHAR(100), @p_password VARCHAR(100), @p_createdDate DATETIME) as
BEGIN
    INSERT INTO accounts (username, password, createdDate) VALUES (p_username, p_password, p_createdDate);
END  
go ;

-- Stored procedure for 'Read'
go  
CREATE PROCEDURE sp_GetAccounts as
BEGIN
    SELECT * FROM accounts;
END  
go ;

-- Stored procedure for 'Update'
go  
CREATE PROCEDURE sp_UpdateAccount(@p_username VARCHAR(100), @p_newPassword VARCHAR(100)) as
BEGIN
    UPDATE accounts SET password = p_newPassword WHERE username = p_username;
END  
go ;

-- Stored procedure for 'Delete'
go  
CREATE PROCEDURE sp_DeleteAccount(@p_username VARCHAR(100)) as
BEGIN
    DELETE FROM accounts WHERE username = p_username;
END  
go ;
