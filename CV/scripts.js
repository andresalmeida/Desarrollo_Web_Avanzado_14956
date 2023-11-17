document.querySelectorAll('nav li').forEach(navItem => {
    navItem.addEventListener('click', function() {
      const sectionId = this.getAttribute('data-section');
      const sections = document.querySelectorAll('.section');
  
      sections.forEach(section => {
        if (section.id === sectionId) {
          section.style.display = 'block';
        } else {
          section.style.display = 'none';
        }
      });
    });
  });




  // PARA LA SECCION CONTACTOS

document.querySelectorAll('.email p').forEach(emailElement => {
    emailElement.addEventListener('click', function() {
      const emailText = this.innerText.trim();
  
      // Create a temporary input element
      const input = document.createElement('input');
      input.setAttribute('value', emailText);
      document.body.appendChild(input);
  
      // Select the text in the input
      input.select();
      input.setSelectionRange(0, 99999); // For mobile devices
  
      // Copy the text to the clipboard
      document.execCommand('copy');
  
      // Remove the temporary input
      document.body.removeChild(input);
  
      // Inform the user
      alert(`¡${emailText} ha sido copiado al portapapeles!`);
    });
  });
  