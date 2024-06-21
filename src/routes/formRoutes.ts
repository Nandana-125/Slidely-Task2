import express from 'express';
import { createForm, getForms, getFormById, getFormByEmail, deleteFormById, updateFormByEmail, ping } from '../controllers/formController';

const router = express.Router();

// Route to handle form submission
router.post('/submit', createForm);

router.get('/forms', getForms);
router.get('/form', getFormById);
router.get('/form/email/:email', getFormByEmail);
router.delete('/form/:id', deleteFormById);

router.get('/ping', ping);
router.put('/form/email/:email', updateFormByEmail);


// Define your routes here
router.get('/', (req, res) => {
    res.send('Server running successfully');
  });

export default router;
