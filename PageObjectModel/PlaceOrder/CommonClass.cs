using SQABootCampFinalProject.PageObjectModel.AddToCart;
using SQABOOTCAUMP01_FINAL_PROJECT.PageObjectModel;
using SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.NewFolder1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.Home
{
    public class CommonClass
    {
        Homepage homepage = new Homepage();
        ShoppingList tee = new ShoppingList();
        AddToCartC addtocart = new AddToCartC();
        SignUp signup = new SignUp();
        MyWishList wishlist = new MyWishList();
        ShoppingCart shopcart = new ShoppingCart();
        ShippingAddress shipaddress= new ShippingAddress();
        PlaceOrder order = new PlaceOrder();
        CreateShippingAddress createshpaddress = new CreateShippingAddress();
        UpdateCart updatecart = new UpdateCart();
        AddPhoebeZipperIntoCart phoebeZipper = new AddPhoebeZipperIntoCart();
        public void PlaceOrder1()
        {
            homepage.MoveToAtomicEnduranceItem();
            tee.TeesMethod();
            addtocart.Add_AtomicEndurance_Into_Cart();
            shipaddress.SignInWhileShipping();
            order.Place_Order();
        }
        public void PlaceOrder2(string fname, string lname, string email, string pass, string confirmpass)
        {
            homepage.MoveToIngridRunningItem();
            addtocart.Add_IngridRunning_into_Cart();
            signup.SignUp_While_Addto_WishList(fname, lname, email, pass, confirmpass);
            wishlist.My_Wish_List_Visible();
            addtocart.View_and_Edit_CartItems();
            shopcart.Shopping_Cart_Ingrid();
            shipaddress.Shipping_Address_Ingrid();
            order.Place_Order();

        }
        public void PlaceOrder3(string fname, string lname, string email, string pass, string confirmpass)
        {
          signup.SignUp_Before_CheckOut(fname, lname, email, pass, confirmpass);
            homepage.Move_ToStark_Item();
            addtocart.Add_starkItem_IntoCart();
            shopcart.Shopping_Cart_Stark_Fundamental_Hoodie();
            createshpaddress.Create_Stark_shipping_address();
            order.Plcae_Order_of_Stark_fundamental_Hoodie();
        }
        public void Add_Autumn_puliie_Item_Into_Cart_Update_and_Delete()
        {
            homepage.Move_To_Atomic_Pullie_Item();
            addtocart.Add_Autum_IntoCart();
            shopcart.Shopping_Cart_Autumn_pullie_Edit();
            updatecart.Update_Shopping_Cart();
            shopcart.Delete_Autum_Pullie_item_from_Cart();

        }
        public void Add_Valid_Boundries()
        {
            homepage.MoveTo_Phoebe_Zipper();
            phoebeZipper.AddToCart_Phoebe_With_valid_Boundry();
           
        }
        public void  Add_invalid_Boundries()
        {
            homepage.MoveTo_Phoebe_Zipper();
            phoebeZipper.AddToCart_phoebe_InvalidBoundries();
        }
        public void Add_Without_SizeColorquantity()
        {
            homepage.MoveTo_Phoebe_Zipper();
            phoebeZipper.AddToCart_phoebe_WithoutSizeColorAndQuantity();

        }
        public void Add_Without_ColourAndQuantity()
        {
            homepage.MoveTo_Phoebe_Zipper();
            phoebeZipper.AddToCart_phoebe_WithoutColorAndQuantity();

        }
        public void Add_Without_Quantity()
        {
            homepage.MoveTo_Phoebe_Zipper();
            phoebeZipper.AddToCart_phoebe_WithoutQuantity();

        }
        public void Add_Invalid_quantity()
        {
            homepage.MoveTo_Phoebe_Zipper();
            phoebeZipper.AddToCart_phoebe_With_Invalid_Quanity();
        }


    }
}
