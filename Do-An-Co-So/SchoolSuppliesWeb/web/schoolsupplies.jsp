<%@page import="java.text.DecimalFormat"%>
<%@page import="context.AccountDAO"%>
<%@page import="model.SchoolSupplies"%>
<%@page import="java.util.ArrayList"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>SchoolSupplies</title>
        <link rel="icon" href="//bizweb.dktcdn.net/100/220/344/themes/739421/assets/favicon.png?1630832963021" type="image/x-icon" />
        <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
        <link href="bootstrap/css/bootstrap-grid.css" rel="stylesheet" type="text/css" media="all" />
        <%
            String id = request.getParameter("id");
            ArrayList<SchoolSupplies> list = new AccountDAO().getListSchoolSuppliesByCategory(id);
            DecimalFormat formatter = new DecimalFormat("###,###,###");
        %>
    </head>
    <body>
        <jsp:include page="header.jsp"></jsp:include>
            <div class="container" style="padding-top: 100px;">
                <div class="row">
                <%
                    for (SchoolSupplies schoolsupplies : list) {
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
        <jsp:include page="footer.jsp"></jsp:include>
    </body>
</html>
