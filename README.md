# Backend Server



# Prerequisites
Before starting, ensure you have the following installed:

` Node.js (version >= 14.0.0) `
` npm (Node Package Manager) or yarn `


## Installation

1. Clone the repository.
2. Navigate to the backend directory: `cd backend`
3. Install dependencies: `npm install` This guide provides instructions to set up and run the backend server for managing form submissions using a JSON file for storage. 

# typescript and express dependancies : 

bash
`npm init -y`
`npm install -D typescript @types/express @types/node @types/body-parser @types/cors ts-node`
`npm install express body-parser mongoose cors`



## Running the Server

bash 
` npm start ` or ` ts-node src/index.ts`


# or

yarn start
The server should start running at `http://localhost:5000 `(or another specified port).

Verify server status:

Open your browser and go to` http://localhost:5000`. You should see a message like `Backend server is running` or similar. 
might get ' /cannotGET ' but it will still work .

# API Endpoints
POST /submit: Create a new form submission.
GET /forms: Retrieve all form submissions.
GET /form/
: Retrieve a form submission by ID.
GET /form/email/
: Retrieve a form submission by email.
PUT /form/
: Update a form submission by ID.
DELETE /form/
: Delete a form submission by ID.
Data Storage
Form submissions are stored locally in a JSON file (forms.json) within the project's db directory.


 

## Running the Server

` npm start ` or ` ts-node src/index.ts`

### Development
```bash
npm run dev


## front end exe file
` <your path>\bin\release\net8.0-windows\publish `

## if NuGet json package is not installed

go to the form app in the solution explorer  -> right click -> NuGet package manager -> install Nuget.Json 
