<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Đăng nhập quản trị viên</title>
        <link rel="stylesheet" href="../css/login.css">
        <link rel="icon" href="../images/logo.ico" type="image/icon">
    </head>
    <body>
        <div class="wrapper fadeInDown">
            <div id="formContent">
                <h2 class="active"> Login </h2>
                <form action="/SchoolSuppliesWeb/AdminLogin" method="POST">
                    <input type="text" id="login" value="" class="fadeIn second" name="accountName" placeholder="Username" required="">
                    <input type="password" id="password" value="" class="fadeIn fifth" name="accountPass" placeholder="Password" required="">
                    <input type="submit" name="submit" class="fadeIn fifth" value="login">
                </form>
            </div>
        </div>
    </body>
</html>
