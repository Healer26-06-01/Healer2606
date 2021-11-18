<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Login</title>
        <meta charset="UTF-8">
        <link rel="stylesheet" href="css/login.css">
        <link rel="icon" href="//bizweb.dktcdn.net/100/220/344/themes/739421/assets/favicon.png?1630832963021" type="image/x-icon" />
    </head>
    <body>
        <div class="wrapper fadeInDown">
            <div id="formContent">
                <!-- Tabs Titles -->
                <h2 class="active"> Login </h2>
                <h3>${loginError}</h3>
                <h3>${RegistrationSuccess}</h3>
                <!-- Icon -->
                <div class="fadeIn first">
                    <img src="images/logo.ico" id="icon" alt="Web Icon" />
                </div>
                <!-- Login Form -->
                <form action="login" method="POST">
                    <input type="text" id="login" value="${cookie['name'].getValue()}" class="fadeIn second" name="accountName" placeholder="Username" required="">
                    <input type="password" id="password" value="${cookie['pass'].getValue()}" class="fadeIn fifth" name="accountPass" placeholder="Password" required="">
                    <div class="fadeIn fourth">
                        <input id="check" type="checkbox" name="remember" class="check">
                        <label for="check"><span class="icon"></span>Remember me</label>
                    </div>
                    <input type="submit" name="submit" class="fadeIn fifth" value="login">
                </form>
                or <a href="register.jsp" style="color: #000000;">Registration</a>
            </div>
        </div>
    </body>
</html>
