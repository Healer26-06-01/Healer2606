<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Liên hệ</title>
        <link rel="icon" href="//bizweb.dktcdn.net/100/220/344/themes/739421/assets/favicon.png?1630832963021" type="image/x-icon" />
        <link rel="stylesheet" type="text/css" href="css/style.css">
    </head>
    <body>
        <jsp:include page="header.jsp"></jsp:include>
            <div class="contact">
                <div class="container">
                    <h3>Liên hệ</h3>
                    <br><br>
                    <div class="col-md-8 contact-grids1">
                        <form action="contact" method="POST">
                            <div class="contact-form2">
                                <h4>Họ và tên</h4>
                                <input type="text" placeholder="" name="name" required>
                            </div>
                            <div class="contact-form2">
                                <h4>Email</h4>
                                <input type="email" name="email" placeholder="" required>
                            </div>
                            <div class="contact-form2">
                                <h4>Tiêu đề</h4>
                                <input type="text" name="title" placeholder="" required>
                            </div>
                            <div class="contact-me ">
                                <h4>Lời nhắn</h4>
                                <textarea type="text" name="message"  placeholder="" required> </textarea>
                            </div>
                            <input type="hidden" name="command" value="insert">
                            <input type="submit" value="Gửi Liên Hệ" >
                        </form>
                    </div>               
                </div>
            </div>
            <div class="map">
                <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d1748.3462683280034!2d106.70862490771101!3d10.34951617570627!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2s!4v1630798090366!5m2!1sen!2s" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
            </div>
        <jsp:include page="footer.jsp"></jsp:include>
    </body>
</html>
