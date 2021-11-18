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
public class SchoolSupplies {

    private String schoolsuppliesID;
    private int categoryID;
    private String schoolsuppliesName;
    private String schoolsuppliesImage;
    private long schoolsuppliesPrice;
    private String schoolsuppliesDescription;

    public SchoolSupplies(String schoolsuppliesID, int categoryID, String schoolsuppliesName, String schoolsuppliesImage, long schoolsuppliesPrice, String schoolsuppliesDescription) {
        this.schoolsuppliesID = schoolsuppliesID;
        this.categoryID = categoryID;
        this.schoolsuppliesName = schoolsuppliesName;
        this.schoolsuppliesImage = schoolsuppliesImage;
        this.schoolsuppliesPrice = schoolsuppliesPrice;
        this.schoolsuppliesDescription = schoolsuppliesDescription;
    }

    public SchoolSupplies() {
    }

    public String getSchoolSuppliesID() {
        return schoolsuppliesID;
    }

    public void setSchoolSuppliesID(String schoolsuppliesID) {
        this.schoolsuppliesID = schoolsuppliesID;
    }

    public int getCategoryID() {
        return categoryID;
    }

    public void setCategoryID(int categoryID) {
        this.categoryID = categoryID;
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

    public long getSchoolSuppliesPrice() {
        return schoolsuppliesPrice;
    }

    public void setSchoolSuppliesPrice(long schoolsuppliesPrice) {
        this.schoolsuppliesPrice = schoolsuppliesPrice;
    }

    public String getSchoolSuppliesDescription() {
        return schoolsuppliesDescription;
    }

    public void setSchoolSuppliesDescription(String schoolsuppliesDescription) {
        this.schoolsuppliesDescription = schoolsuppliesDescription;
    }

}
