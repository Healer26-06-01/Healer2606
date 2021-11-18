<%@page import="java.text.DecimalFormat"%>
<%@page import="java.util.ArrayList"%>
<%@page import="context.AccountDAO"%>
<%@page import="model.SchoolSupplies"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <title>Welcome to Crabit Notebuck</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="icon" href="//bizweb.dktcdn.net/100/220/344/themes/739421/assets/favicon.png?1630832963021" type="image/x-icon" />
        <link rel="stylesheet" type="text/css" href="css/style.css">
        <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.css">
        <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap-grid.css">
        <link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap-grid.min.css">
        <%
            String id = request.getParameter("id");
            ArrayList<SchoolSupplies> listNewSchoolSupplies = new AccountDAO().getTop6ListNewSchoolSupplies();
            ArrayList<SchoolSupplies> listNoteBookSchoolSupplies = new AccountDAO().getTop6ListSchoolSupplies(1);
            ArrayList<SchoolSupplies> listPlayWrightSchoolSupplies = new AccountDAO().getTop6ListSchoolSupplies(2);
             ArrayList<SchoolSupplies> listPenSchoolSupplies = new AccountDAO().getTop6ListSchoolSupplies(3);
              ArrayList<SchoolSupplies> listStickerSchoolSupplies = new AccountDAO().getTop6ListSchoolSupplies(4);
               ArrayList<SchoolSupplies> listClaySchoolSupplies = new AccountDAO().getTop6ListSchoolSupplies(5);
            DecimalFormat formatter = new DecimalFormat("###,###,###");
        %>
    </head>
    <body>
        <jsp:include page="header.jsp"></jsp:include>
            <div class="container" style="padding-top: 100px;">
                <h2>Dụng cụ học tập mới</h2>
                <div class="row">
                <%
                    for (SchoolSupplies schoolsupplies : listNewSchoolSupplies) {
                %>
                <div class="col-md-3">		
                    <a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>">
                        <div>
                            <img src="<%=schoolsupplies.getSchoolSuppliesImage()%>"  alt="" width="280" height="400">
                        </div>			
                    </a>			
                    <div class="women">
                        <h6><a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>"><%=schoolsupplies.getSchoolSuppliesName()%></a></h6>
                        <p><em class="item_price"><%=formatter.format(schoolsupplies.getSchoolSuppliesPrice())%> VNĐ</em>
                            <br>
                            <a href="cart?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>" data-text="Thêm vào giỏ">Thêm vào giỏ</a>
                        </p>
                    </div>
                </div>
                <%}%>
            </div>
            <br><br><br>
            <h2>Sổ tay</h2>
            <div class="row">
                <%
                    for (SchoolSupplies schoolsupplies : listNoteBookSchoolSupplies) {
                %>
                <div class="col-md-3">		
                    <a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>">
                        <div>
                            <img src="<%=schoolsupplies.getSchoolSuppliesImage()%>"  alt="" width="280" height="400">
                        </div>			
                    </a>			
                    <div class="women">
                        <h6><a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>"><%=schoolsupplies.getSchoolSuppliesName()%></a></h6>
                        <p><em class="item_price"><%=formatter.format(schoolsupplies.getSchoolSuppliesPrice())%> VNĐ</em>
                            <br>
                            <a href="cart?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>" data-text="Thêm vào giỏ">Thêm vào giỏ</a>
                        </p>
                    </div>
                </div>
                <%}%>
            </div>
            <br><br><br>
            <h2>Vở viết</h2>
            <div class="row">
                <%
                    for (SchoolSupplies schoolsupplies : listPlayWrightSchoolSupplies) {
                %>
                <div class="col-md-3">		
                    <a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>">
                        <div>
                            <img src="<%=schoolsupplies.getSchoolSuppliesImage()%>"  alt="" width="280" height="400">
                        </div>			
                    </a>			
                    <div class="women">
                        <h6><a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>"><%=schoolsupplies.getSchoolSuppliesName()%></a></h6>
                        <p><em class="item_price"><%=formatter.format(schoolsupplies.getSchoolSuppliesPrice())%> VNĐ</em>
                            <br>
                            <a href="cart?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>" data-text="Thêm vào giỏ">Thêm vào giỏ</a>
                        </p>
                    </div>
                </div>
                <%}%>
            </div>
            <br><br><br>
            <h2>Bút</h2>
            <div class="row">
                <%
                    for (SchoolSupplies schoolsupplies : listPenSchoolSupplies) {
                %>
                <div class="col-md-3">		
                    <a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>">
                        <div>
                            <img src="<%=schoolsupplies.getSchoolSuppliesImage()%>"  alt="" width="280" height="400">
                        </div>			
                    </a>			
                    <div class="women">
                        <h6><a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>"><%=schoolsupplies.getSchoolSuppliesName()%></a></h6>
                        <p><em class="item_price"><%=formatter.format(schoolsupplies.getSchoolSuppliesPrice())%> VNĐ</em>
                            <br>
                            <a href="cart?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>" data-text="Thêm vào giỏ">Thêm vào giỏ</a>
                        </p>
                    </div>
                </div>
                <%}%>
            </div>
            <br><br><br>
            <h2>Sticker</h2>
            <div class="row">
                <%
                    for (SchoolSupplies schoolsupplies : listStickerSchoolSupplies) {
                %>
                <div class="col-md-3">		
                    <a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>">
                        <div>
                            <img src="<%=schoolsupplies.getSchoolSuppliesImage()%>"  alt="" width="280" height="400">
                        </div>			
                    </a>			
                    <div class="women">
                        <h6><a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>"><%=schoolsupplies.getSchoolSuppliesName()%></a></h6>
                        <p><em class="item_price"><%=formatter.format(schoolsupplies.getSchoolSuppliesPrice())%> VNĐ</em>
                            <br>
                            <a href="cart?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>" data-text="Thêm vào giỏ">Thêm vào giỏ</a>
                        </p>
                    </div>
                </div>
                <%}%>
            </div>
            <br><br><br>
            <h2>Đất sét tự khô</h2>
            <div class="row">
                <%
                    for (SchoolSupplies schoolsupplies : listClaySchoolSupplies) {
                %>
                <div class="col-md-3">		
                    <a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>">
                        <div>
                            <img src="<%=schoolsupplies.getSchoolSuppliesImage()%>"  alt="" width="280" height="400">
                        </div>			
                    </a>			
                    <div class="women">
                        <h6><a href="schoolsuppliesDetails.jsp?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>"><%=schoolsupplies.getSchoolSuppliesName()%></a></h6>
                        <p><em class="item_price"><%=formatter.format(schoolsupplies.getSchoolSuppliesPrice())%> VNĐ</em>
                            <br>
                            <a href="cart?schoolsuppliesID=<%=schoolsupplies.getSchoolSuppliesID()%>" data-text="Thêm vào giỏ">Thêm vào giỏ</a>
                        </p>
                    </div>
                </div>
                <%}%>
            </div>
        </div>
    </div>
    <jsp:include page="footer.jsp"></jsp:include>
    <script src="bootstrap/js/jquery.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
