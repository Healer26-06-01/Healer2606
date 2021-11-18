/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author HEALER
 */
public class BillDetail {

    private int billDetailID;
    private String schoolsuppliesID;
    private int accountID;
    private String schoolsuppliesName;
    private String schoolsuppliesImage;
    private long price;
    private int quantity;

    public BillDetail(int billDetailID, String schoolsuppliesID, int accountID, String schoolsuppliesName, String schoolsuppliesImage, long price, int quantity) {
        this.billDetailID = billDetailID;
        this.schoolsuppliesID = schoolsuppliesID;
        this.accountID = accountID;
        this.schoolsuppliesName = schoolsuppliesName;
        this.schoolsuppliesImage = schoolsuppliesImage;
        this.price = price;
        this.quantity = quantity;
    }

    public BillDetail(String schoolsuppliesID, int accountID, String schoolsuppliesName, String schoolsuppliesImage, long price, int quantity) {
        this.schoolsuppliesID = schoolsuppliesID;
        this.accountID = accountID;
        this.schoolsuppliesName = schoolsuppliesName;
        this.schoolsuppliesImage = schoolsuppliesImage;
        this.price = price;
        this.quantity = quantity;
    }

    public BillDetail() {
    }

    public int getBillDetailID() {
        return billDetailID;
    }

    public void setBillDetailID(int billDetailID) {
        this.billDetailID = billDetailID;
    }

    public String getSchoolSuppliesID() {
        return schoolsuppliesID;
    }

    public void setSchoolSuppliesID(String schoolsuppliesID) {
        this.schoolsuppliesID = schoolsuppliesID;
    }

    public int getAccountID() {
        return accountID;
    }

    public void setAccountID(int accountID) {
        this.accountID = accountID;
    }

    public String getSchoolSuppliesName() {
        return schoolsuppliesName;
    }

    public void setSchoolSuppliesName(String schoolsuppliesName) {
        this.schoolsuppliesName = schoolsuppliesName;
    }

    public String getSchoolSuppliesImage() {
        return schoolsuppliesImage;
    }

    public void setSchoolSuppliesImage(String schoolsuppliesImage) {
        this.schoolsuppliesImage = schoolsuppliesImage;
    }

    public long getPrice() {
        return price;
    }

    public void setPrice(long price) {
        this.price = price;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

}
