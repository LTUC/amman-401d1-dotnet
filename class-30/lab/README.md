# E-Commerce Application: Sprint 1

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

### Readme & Documentation (5 points)

Readme contains an introduction to the web application. ReadMe contains all required questions as well as a link to the deployed site. All contributors are referenced and cited within the ReadMe.
**NO POINTS WILL BE GIVEN FOR THE ASSIGNMENT IF DEPLOYMENT LINKS ARE NOT PRESENT OR IS NOT FUNCTIONAL*

### MVC Skeleton & Scaffold (10pts)

- Site contains basic MVC Scaffold including a DBContext with basic products seeded into database.
- Site implements the repository design pattern with appropriate interfaces and services.
- D.I. is properly registered in Startup.cs file.

### Login Page (5 points)

- Login page consists of username and password form with the password masked for visibility.
- Upon successful login:
  - Redirect to Admin Dashboard Page
  - Set a **Browser Cookie** with the user's authentication token
- Login page utilizes ASP.NET Core Identity.

### Admin Dashboard (10 points)

- A valid administrator level account is required to access the dashboard
  - Use the **Browser Cookie** to re-authenticate logged in users
- Administrators with the appropriate permissions  can View, Add, Edit, Delete **Product Categories**
- Administrators with the appropriate permissions  can View, Add, Edit, Delete **Products**
  - Products can be associated to a category

### Azure Blob (5 points)

- All product images must be stored in Azure.

### User Experience (5 points)

- HTML/CSS is present across the site.
- Site is clean and professional looking.
- Pages are properly linked and the overall experience and flow of the site is usable.
- Site does not contain any unhandled exceptions.

### Azure DevOps Process (5 points)

- Azure DevOps tool is properly maintained.
- User stories assigned to each member are properly filled out, including time estimation, tasks, branches, description, and acceptance tests.
- 50% of these points are for all partner's overall maintenance of the KanBan board,
- 50% of these points are dedicated to each individual partner for specific maintenance.
- These points CANNOT be regained.

### Industry Standard (5 points)

- Summary Comments are present and completed.
- Methods and variable names are appropriate.
- Fundamentals are properly used.
- No misuse of code or industry standards present

### Even Workload (-20% deduction)

- All User stories and work completed within this sprint was approx even between all partners.
- Partners properly communicated with each other and no major conflicts were present during sprint.
- (20% deduction to overall sprint will be applied if necessary)




