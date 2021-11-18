/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import context.AccountDAO;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import model.SchoolSupplies;

/**
 *
 * @author HEALER
 */
public class AdminEditSchoolSupplies extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        request.setCharacterEncoding("utf-8");
        try {
            String schoolsuppliesId = request.getParameter("schoolsuppliesId");
            int categoryId = Integer.parseInt(request.getParameter("categoryId"));
            String schoolsuppliesName = request.getParameter("schoolsuppliesName");
            String schoolsuppliesImage = "images/schoolsupplies/" + request.getParameter("schoolsuppliesImage");
            long schoolsuppliesPrice = Long.parseLong(request.getParameter("schoolsuppliesPrice"));
            String schoolsuppliesDescription = request.getParameter("schoolsuppliesDescription");
            SchoolSupplies schoolsupplies = new SchoolSupplies(schoolsuppliesId, categoryId, schoolsuppliesName, schoolsuppliesImage, schoolsuppliesPrice, schoolsuppliesDescription);
            AccountDAO accountDAO = new AccountDAO();
            int n = accountDAO.editSchoolSupplies(schoolsupplies);
            response.sendRedirect("admin/schoolsupplies.jsp");
        } catch (Exception ex) {
            Logger.getLogger(AdminEditSchoolSupplies.class.getName()).log(Level.SEVERE, null, ex);
        }

    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
