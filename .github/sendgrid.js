// .github/sendgrid.js
const sgMail = require('@sendgrid/mail');
sgMail.setApiKey(process.env['INPUT_API-KEY'] || process.env['SENDGRID_API_KEY']);

const msg = {
  to: process.env['INPUT_TO'],
  from: process.env['INPUT_FROM'],
  subject: process.env['INPUT_SUBJECT'],
  text: process.env['INPUT_BODY'],
};
sgMail.send(msg).then(() => {
  console.log('Email sent');
}).catch((error) => {
  console.error(error);
  process.exit(1);
});
