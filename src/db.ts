import { promises as fs } from 'fs';
import path from 'path';

const dbPath = path.join(__dirname, 'db', 'db.json');

export const readDB = async () => {
  const data = await fs.readFile(dbPath, 'utf8');
  return JSON.parse(data);
};

export const writeDB = async (data: any) => {
  await fs.writeFile(dbPath, JSON.stringify(data, null, 2), 'utf8');
};
