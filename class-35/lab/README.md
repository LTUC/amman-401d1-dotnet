# E-Commerce Application: Sprint 2

## Submission Schedule

You will have 4 Class/Lab days to work on this sprint.

You will only have 48 hours from the initial due date of this sprint to submit your work. Anything past the 48 hours will not be accepted, and you will receive a zero for this sprint. Each individual is responsible for their own submission.

Re-Submits for this sprint will only be accepted upon evaluation of sprint 2:

For example, Your team received feedback that you need to fix an error in one or two of your milestones. Instead of doing a submission and pushing to main halfway through your sprint 2, you will be required to **explicitly** tell your grader what you want them to regrade from sprint 1 when you submit for sprint 2. You will not be able to do any additional "resubmits" for sprint 1 once sprint 2 is due and graded. Plan accordingly.

You will each individually submit the following into Canvas as a text entry:

1. A deployed link to your azure website
2. Collaborate with each other and come up with
  - What you did well
  - What you will do differently next sprint
3. Do you need anything from the instructional staff? (these comments are confidential and only shared with instructional staff)

The instructional staff will review your current main branch in Azure Dev Ops and evaluate you based on the rubric below.

**Only push to main on sprint check-ins**

## Checkin Requirements

1. All pages should have basic CSS/HTML with a good overall user experience.
2. Web app and databases should be deployed to Azure
3. The application must have a well constructed README
  - Link to your deployed website
  - What is the product you are selling?
  - Structure/Database Schema for your store DB (not identity)
  - Explanation of your DB Schema (mostly interested in your basket/order tables)
  - What claims are you capturing? Where? Why? -
  - What Policies are you enforcing? Why?

## Rubric and Requirements (50 points)

Review the rubric below to know and understand the overall expectations

### Registration Page (5 points)

- Registration page consists of a form that successfully creates a new account while utilizing ASP.NET Core Identity.
- Custom claims are properly captured within registration.
- A welcome email is sent to the user upon a new registration.
- User is automatically logged in and redirects user to home page after registration.
- Registration is accessible by anonymous users.

### Home Page (5 points)

- Introduction to the site with HTML/CSS. Anonymous accessibility.
- Home page contains login/register links as well as custom greeting for logged in users

### Products Page (5 points)

- Shopping page is accessible by anonymous users as well as fully displays all products existing in the database.
- Each product is evenly displayed on the page and shopping page has a clean professional appearance.

#### Mini Cart (5 points)

- "Mini Basket" exists on product landing pages.
- Mini Basket holds a current view of all the existing items the user has in their cart.
- A view component is used to implement the mini cart across the site.

#### Cart (5 points)

- A dedicated cart page that consists of all the user's current products.
- Items in the cart can be modified in quantity or removed.
- Home page consists of a link to the cart page for easability.
- Cart page contains a "Checkout" button that redirects to the Receipt page.
- The user must be logged in to access the cart page.

#### Auth.NET/Checkout Process (5 points)

- Authorize.NET is present and hooked up within the application.
- The checkout page is present and prompts the user to "complete" their order by selecting either a drop down menu of a test credit card or just has as a checkout button present.
- Receipt page consists of an itemized list of all products that the user has "purchased".
- Includes Item name, Quantity, and total price of each item
- Includes total price of all items in the basket.

> NO POINTS WILL BE AWARDED FOR THE ENTIRE SPRINT IF THERE EXISTS A CREDIT CARD BOX ALLOWING FOR REAL NUMBERS*

#### Order Notification (5 points)

- A receipt email is also sent to the user after the "checkout" process from the basket page.
- Each email is fitting to the problem domain, and formatted professionally.
- The email consists of a custom greeting and personalization.

#### Admin Dashboard (5 points)
- Admin Dashboard includes a page listing all orders

#### User Experience (5 points)
- HTML/CSS/SCSS is present across the site.
- Site is clean and professional looking.
- Pages are properly linked and the overall experience and flow of the site is usable.
- Site does not contain any unhandled exceptions.

#### Readme, Documentation, Process (5 points)
- Readme contains an introduction to the web application.
- Azure DevOps tool is properly maintained.
- User stories assigned to each member are properly filled out, including time estimation, tasks, branches, description, and acceptance tests.
- 50% of these points are for both partner's overall maintenance of the KanBan board,
- 50% of these points are dedicated to each individual partner for specific maintenance.
- These points CANNOT be regained.

> **NO POINTS WILL BE GIVEN FOR THE ASSIGNMENT IF DEPLOYMENT LINKS ARE NOT PRESENT OR IS NOT FUNCTIONAL*

#### Even Workload (-20% deduction)

- All User stories and work completed within this sprint was approx even between all partners.
- Partners properly communicated with each other and no major conflicts were present during sprint.
- **up to a 20% deduction to overall sprint will be applied if necessary**
- These points cannot be regained.

