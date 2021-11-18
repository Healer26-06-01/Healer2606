package org.apache.jsp.admin;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import model.Account;

public final class home_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html; charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\n");
      out.write("        <title>Trang chủ</title>\n");
      out.write("        <link rel=\"icon\" href=\"../images/logo.ico\" type=\"image/icon\">\n");
      out.write("        <link rel=\"stylesheet\" type=\"text/css\" href=\"../css/style.css\">\n");
      out.write("        <link rel=\"stylesheet\" type=\"text/css\" href=\"../bootstrap/css/bootstrap.min.css\">\n");
      out.write("        ");

            Object account = session.getAttribute("accountAdmin");
            if (account == null) {
                response.sendRedirect("login.jsp");
            }
        
      out.write("\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("        ");
      org.apache.jasper.runtime.JspRuntimeLibrary.include(request, response, "header.jsp", out, false);
      out.write("\n");
      out.write("        <div class=\"container\">\n");
      out.write("            <div class=\"row\">\n");
      out.write("                <div class=\"col-md-2\"></div>\n");
      out.write("                <div class=\"col-md-2\">\n");
      out.write("                    <a href=\"home.jsp\"><img alt=\"\" src=\"../images/home.png\">\n");
      out.write("                        <p style=\"text-align: center; font-size: 20px;\">Trang chủ</p></a>\n");
      out.write("                </div>\n");
      out.write("                <div class=\"col-md-2\">\n");
      out.write("                    <a href=\"type.jsp\"><img alt=\"\" src=\"../images/categorys.png\">\n");
      out.write("                        <p style=\"text-align: center; font-size: 20px;\">Thể loại</p></a>\n");
      out.write("                </div>\n");
      out.write("                <div class=\"col-md-2\">\n");
      out.write("                    <a href=\"schoolsupplies.jsp\"><img alt=\"\" src=\"../images/schoolsupplies.png\">\n");
      out.write("                        <p style=\"text-align: center; font-size: 20px;\">Dụng cụ học tập</p></a>\n");
      out.write("                </div>\n");
      out.write("                <div class=\"col-md-2\">\n");
      out.write("                    <a href=\"uploadImage.jsp\"><img alt=\"\" src=\"../images/picture.png\">\n");
      out.write("                        <p style=\"text-align: center; font-size: 20px;\">Tải ảnh lên</p></a>\n");
      out.write("                </div>\n");
      out.write("                <div class=\"col-md-2\"></div>\n");
      out.write("                <div class=\"col-md-2\"></div>\n");
      out.write("                <div class=\"col-md-2\">\n");
      out.write("                    <a href=\"account.jsp\"><img alt=\"\" src=\"../images/users.png\">\n");
      out.write("                        <p style=\"text-align: center; font-size: 20px;\">Người dùng</p></a>\n");
      out.write("                </div>\n");
      out.write("                <div class=\"col-md-2\">\n");
      out.write("                    <a href=\"bill.jsp\"><img alt=\"\" src=\"../images/bill.png\">\n");
      out.write("                        <p style=\"text-align: center; font-size: 20px;\">Hóa đơn</p></a>\n");
      out.write("                </div>\n");
      out.write("                <div class=\"col-md-2\">\n");
      out.write("                    <a href=\"contact.jsp\"><img alt=\"\" src=\"../images/contact.png\">\n");
      out.write("                        <p style=\"text-align: center; font-size: 20px;\">Liên hệ</p></a>\n");
      out.write("                </div>\n");
      out.write("                <div class=\"col-md-2\">\n");
      out.write("                    <a href=\"/SchoolSuppliesWeb/AdminLogout\"><img alt=\"\" src=\"../images/logout.png\">\n");
      out.write("                        <p style=\"text-align: center; font-size: 20px;\">Đăng xuất</p></a>\n");
      out.write("                </div>\n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("    </body>\n");
      out.write("</html>\n");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
