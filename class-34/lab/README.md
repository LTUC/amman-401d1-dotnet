# E-Commerce Sprint 2 - Milestone 4:  Payment Processing

Work together with your partner(s) to complete this lab.

> NOTE: Your team workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow.[Azure DevOps CheatSheet](https://codefellows.github.io/code-401-dotnet-guide/curriculum/projects/ecommerce/azure-devops-cheatsheet)

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.

## Consumer Site (The Storefront)

In this last phase of the store build, we'll be adding the ability to process the order using an actual credit card transaction processor - Authorize.net.

Inject a process between the user "completing" their order and the communications phase. Process the consumer's credit card and only complete the order process (emails and receipt) if the card was valid and monies paid.

## Admin Dashboard

We'll want to see a new page with a list of all orders that were successfully paid and processed.

### User Stories and Tasks

Divide your work evenly amongst your team members.

1. As a user,  I would like to see a summary of my purchase after completing my checkout process with a successful transaction
1. As a user, following a successful transaction, I would like a summary of my purchase to be emailed to me so that I can store the receipt for my records.
1. As a user, I would like to be thanked for my purchase following completion of order processing
1. As a user, I would like to be notified if my payment failed so that I can try again.
1. As an administrator, I would like to see a listing of all paid/processed orders

### Guidance

**User Story 1:** This user story will require that you create a "checkout" page. This checkout page should appear after the user selects "Checkout" on their cart/basket page.

Using Authorize.Net, integrate payment into your application. Use the sandbox account to prevent usage of real credit card charges. Integrate the payment using the repository design pattern, and have it injected into your razor page.

When completing an order, capture the following information about the user:

1. First Name
2. Last Name
3. Billing/Shipping Address
4. Billing/Shipping City
5. Billing/Shipping State
6. Billing/Shipping Zip

Generally, each order has it's own "Id", is connected to a specific user, and each order contains a number of order items. A user could potentially have many orders.

Keeping this in mind, expand your database to accept orders for the checkout process. In the next couple labs, we will be showcasing a specific user's order to them within their profile page.

**User Story 2:** After the checkout process is complete, redirect the user to a "receipt" page that shows a summary of the items that they purchased, as well as the order number ,shipping/billing information, and anything else that may be relevant.

**User Story 3:** When the user has completed the checkout process, email them a confirmation of their order.

Hint: When creating the email, consider using the SendGrid design templates. Not required, but encouraged.

Also consider using `StringBuilder` when creating the text for the email, this is much more efficient than concatenating a string together.

### Questions

1. Do we want to save this information anywhere in the database?
1. should we keep track of all the transactions?
1. what information should we save (or not save)?

## Tests

- Conditionally test the rendering of the receipt and denial pages

## Workflow

- Continue to work in your `E-Commerce-App` repository
- Create a branch named `sprint-#-milestone-#`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
  - Include answers to the following questions:
    1. What surprised you most about this milestone?
    1. How long did it take you to complete this milestone?
    1. How long did you expect to take?
    1. What did you find most challenging about this milestone?
    1. What do you need to continue to work on during this project?
    1. Any Concerns that the instructional staff should be aware of

## Rubric

The lab rubric can be found [HERE](../resources/rubric){:target="_blank"}
