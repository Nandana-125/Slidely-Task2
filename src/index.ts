import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import formRoutes from './routes/formRoutes';

const app = express();
const PORT = process.env.PORT || 5000;

// Middleware
app.use(bodyParser.json());

// Routes
app.use('/', formRoutes);

// Start server
app.listen(PORT, () => {
  console.log(`Server running on port ${PORT}`);

});


