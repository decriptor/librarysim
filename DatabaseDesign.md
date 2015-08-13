# Database Design #

Some of the columns might not get used, but if there is time it would be cool to add them.

## Database: librarysim ##

### Table: Patron ###
  * ID
  * Name
  * Phone Number
  * Address
  * Gender
  * Date of Birth

### Table: Books ###
  * ID
  * Patron ID
  * Type
  * Title
  * Author
  * Description
  * Checked In
  * Checked Out
  * Reserved

### Table: Media ###
  * ID
  * Patron ID
  * Type
  * Title
  * Rating
  * Description
  * Checked In
  * Checked Out
  * Reserved