# Final E-Commerce

This is your final submission for your E-Commerce site. Your Final E-Commerce site must be transferred to GH with your history of commits. See below on how to do this.

There will be no resubmits available for this Project. Keep an eye on the due and close date. **These are final.**

Focus on your product presentation for this phase. Make sure everything works as expected and there are no exceptions or broken pages.

## Azure Dev Ops to Github:

Following the directions located [HERE](https://help.github.com/articles/changing-a-remote-s-url/){:target="_blank"} Redirect your URL from Azure Repos To GitHub. You will likely have to create a repository first before redirecting.

**NOTE**: Refer to the Switching Remote URLs from SSH to HTTPS

> Why are we making you move your code from ADO to GitHub? We want you to know how to work in Azure as a workflow, but ultimately, when you're in the interviewing process, we want all of your projects to be in the same place so that your potential employers can see **all of your work**


## Final Submission
Upon completion of this Project, Your E-commerce site should contain the following:
1. Home Page
  - Introduction to your site
  - Anonymous accessibility
1. Login Page
  - Login to an existing account
  - Anonymous accessibility
1. Registration Page
  - Create an account
  - Anonymous Accessibility
1. Admin Dashboard
  - Only accessible by users who hold the role of admin
  - Manage Products (Full CRUD)
    - CRUC operations accessible only by users who hold the correct policy
  - View all orders submitted
1. Shopping Page
  - Shows all products in inventory for users to browse
  - Anonymous Access
1. Product Landing Page
  - Displays individual information about each product
  - Anonymous Access
1. Basket Page
  - View all items in the basket. Allow ability to edit/remove the item.
  - Authorize Access Only
1. Checkout page
  - Must be logged in/Authorized
  - Transfer products from their "basket" to an "Order"
1. Receipt/Order Confirmation Page
  - Must be logged in/Authorized
  - Summary of the order that the user just completed.
1. Stretch Goal: Profile Page
- View personal orders
- View personal information

### Shared
- CSS/HTML
  - This should be polished. Make it look nice. ALL pages should have client/ready CSS.
- Exception and error handling. Make sure errors appear when incorrect data is submitted
- The overall flow of each page should be finalized. Make this site as professional looking as possible.
- Deployed to Azure
- Your readme should contain the following:
- Readme should contain the following:
  - Introduction to your E-Commerce site
  - What is the product you are selling?
  - What claims are you capturing? Why?
  - Structure/Database Schema for your store DB (not identity)
  - Explanation of your DB Schema (mostly interested in your basket/order tables)
  - Link to your deployed website
  - Link and reference to your vulnerability report (should be a separate file in your repo)
  - Name of Contributors

- Tests
  - Test all methods that live in your services that implement your interface
  - You do not have to test identity API or the identity DB.


### Submit
Submit into Canvas a link to your GH repo.

## Final E-Commerce Rubric

Below is the breakdown of the final submission of the final E-Commerce project. Use this rubric when grading final submissions as an idea of what is expected.

## Home Page - 5pts
Introduction to the product. Able to easily tell what product is being sold. The layout is clean, professional. The Homepage consists of a Register/Login button, and basket link, as well as a personalized greeting for the user logged in.

## Login Page - 5pts
Login page has a username and a password field., with both required. Password is masked. The login page for a new user redirects to the home page and the login for an admin redirects to an admin panel.

## Registration Page - 5pts
Separate page that looks and feels clean/professional/easy to navigate. Registration Page is accessible by anonymous users. Collects minimum data required for a user to register for the site. All required fields throw an error when not filled out. An account gets successfully created upon registration and redirected back to home page. Claims are being captured and saved by the application upon successful registration. User is being added to a member role upon registration. Potentially a special case for admin registration. Email is sent to user upon new registration.

## Admin Dashboard - 5pts
CSS looks clean and professional. Page is only accessible by Admin users. Links are present to see last 20 submitted orders by all users, and ability to manage (CRUD) of products.

## Shopping Page - 5pts
The site contains a page where all products in the inventory are visible for users to browse. CSS/HTML of page is clean and easy to navigate. Each product that displays links to a product landing page. Price of product is visible and each product has an image associated with it.

## Product Landing Page - 5pts
Each product has it's own product landing page. The product landing page has clean and readable CSS. Able to easily see the product's details and image. Able to easily add the product to your personal cart.


## Basket Page - 5pts
Page has clean and professional looking CSS. Basket Page contains all of the items the user has added to their basket. Able to easily "proceed" to a checkout page. User is able to remove items from their basket. Page consists of an order total of all items in the cart so far. View component is also present on more than one page that shows all of the current logged in users items in their cart. The cart will update as new items are added.

## Checkout Page - 5pts
CSS/Design of page is professional and clean. Only accessible by logged in/authorized users. No personal identifiable information is captured.

## Receipt/Order Confirmation Page - 5pts
Order Confirmation page has clean and professional looking CSS. Only accessible by logged in/authorized users. Contains a summary, by line item, of items purchased by the user, including order total. Receipt is emailed to user of summary of order. Text of email is professional

## Vulnerability Report - 4pts
Repo consists of a vulnerability report that outlines at least 4 potential vulnerabilities. Vulnerabilities are formatted within the provided template and each section contains relevant and appropriate information.

## Overall Design and Experience - 25pts
Overall look and feel of the site looks clean and fits the theme of the product. Color Scheme is appropriate and overall navigation has a nice flow. Users are able to easily navigate through the site with very little issues

## Readme - 5pts
Readme is present in repo and contains 1. Intro to the site 2. product that is being sold 3. claims that are being captured 4, policies being enforced 5. OAUTH providers being used 6. DB Schema present with explanation 7. Link to Deployed site 8. Link and reference to Vulnerability report. 9. Name of contributors.

## Code Quality - 5pts
Quality of code is up to industry standard. Summary comments are present above each method and action. Comments are present when more explanation is needed. Variables are named appropriately, and there isnt' any unnecessary code classes or blocks that are not being used.

## Email Sender - 5pts
Email sender uses SendGrid and implements the IEmailSender Interface

## Site Skeleton - 3pts
Site uses MVC architectural pattern(Model, View, Controller folders) as well as Razor pages (pages directory). Site utilizes .NET Core's Identity Framework for authentication and authorization.

## Policies - 3pts
Site has and enforces a role based policy (i.e. Admin only), Claims are being enforced on at least one page, and are registered in the Startup.cs file

## Site Functionality - 5pts
Site does not contain broken links or uncompleted pages. Site does not throw 500 errors during basic functionality and usages. Site contains a custom 400 error page to mask errors. (not required) , No developer errors are present to user.

#### Total Points: 100


