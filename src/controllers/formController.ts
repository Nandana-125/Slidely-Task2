import { Request, Response } from 'express';
import { readDB, writeDB } from '../db';
import { IForm } from '../models/Form';

const isError = (error: unknown): error is Error => {
  return error instanceof Error;
};

// Create Form
export const createForm = async (req: Request, res: Response) => {
    try {
      console.log('Received request:', req.body); // Log the request body
      const { name, email, phone, githubLink, stopwatchTime } = req.body;
  
      // Validate input
      if (!name || !email || !phone || !githubLink || !stopwatchTime) {
        return res.status(400).json({ error: 'All fields are required' });
      }
  
      const newForm: IForm = { name, email, phone, githubLink, stopwatchTime };
      const forms = await readDB();
      forms.push(newForm);
      await writeDB(forms);
      res.status(201).json(newForm);
    } catch (err) {
      if (isError(err)) {
        console.error(`Error creating form: ${err.message}`);
        res.status(500).json({ error: err.message });
      } else {
        console.error('An unknown error occurred');
        res.status(500).json({ error: 'An unknown error occurred' });
      }
    }
  };

// Get Forms
export const getForms = async (req: Request, res: Response) => {
  try {
    const forms = await readDB();
    res.status(200).json(forms);
  } catch (err) {
    if (isError(err)) {
      console.error(`Error getting forms: ${err.message}`);
      res.status(500).json({ error: err.message });
    } else {
      console.error('An unknown error occurred');
      res.status(500).json({ error: 'An unknown error occurred' });
    }
  }
};

// Get Form by Index
export const getFormById = async (req: Request, res: Response) => {
  try {
    const index = parseInt(req.query.index as string, 10);
    const forms = await readDB();
    if (index < 0 || index >= forms.length) {
      return res.status(404).json({ msg: 'Form not found' });
    }
    res.status(200).json(forms[index]);
  } catch (err) {
    if (isError(err)) {
      console.error(`Error getting form by ID: ${err.message}`);
      res.status(500).json({ error: err.message });
    } else {
      console.error('An unknown error occurred');
      res.status(500).json({ error: 'An unknown error occurred' });
    }
  }
};

// Get Form by Email
export const getFormByEmail = async (req: Request, res: Response) => {
  try {
    const email = req.params.email;
    const forms = await readDB();
    const form = forms.find((form: IForm) => form.email === email);
    if (!form) {
      return res.status(404).json({ msg: 'Form not found' });
    }
    res.status(200).json(form);
  } catch (err) {
    if (isError(err)) {
      console.error(`Error getting form by email: ${err.message}`);
      res.status(500).json({ error: err.message });
    } else {
      console.error('An unknown error occurred');
      res.status(500).json({ error: 'An unknown error occurred' });
    }
  }
};

// Delete Form by Index
export const deleteFormById = async (req: Request, res: Response) => {
  try {
    const index = parseInt(req.params.id, 10);
    const forms = await readDB();
    if (index < 0 || index >= forms.length) {
      return res.status(404).json({ msg: 'Form not found' });
    }
    forms.splice(index, 1);
    await writeDB(forms);
    res.status(200).json({ msg: 'Form deleted' });
  } catch (err) {
    if (isError(err)) {
      console.error(`Error deleting form by ID: ${err.message}`);
      res.status(500).json({ error: err.message });
    } else {
      console.error('An unknown error occurred');
      res.status(500).json({ error: 'An unknown error occurred' });
    }
  }
};

// Update Form by Email
export const updateFormByEmail = async (req: Request, res: Response) => {
    try {
      const email = req.params.email;
      const { name, phone, githubLink, stopwatchTime } = req.body;
      
      const forms = await readDB();
      const formIndex = forms.findIndex((form: IForm) => form.email === email);
      
      if (formIndex === -1) {
        return res.status(404).json({ msg: 'Form not found' });
      }
      
      // Ensure only updating the specific fields and not creating a new entry
      forms[formIndex] = { ...forms[formIndex], name, phone, githubLink, stopwatchTime };
      await writeDB(forms);
      
      res.status(200).json(forms[formIndex]);
    } catch (err) {
      if (isError(err)) {
        console.error(`Error updating form by email: ${err.message}`);
        res.status(500).json({ error: err.message });
      } else {
        console.error('An unknown error occurred');
        res.status(500).json({ error: 'An unknown error occurred' });
      }
    }
  };

  
export const ping = (req: Request, res: Response) => {
  res.json({ success: true });
};
