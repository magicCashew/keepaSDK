note
 description:"[
		Keepa API
 		The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
  		OpenAPI spec version: 1.0.0
 	    Contact: info@keepa.com

  	NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).

 		 Do not edit the class manually.
 	]"
	date: "$Date$"
	revision: "$Revision$"
	EIS:"Eiffel openapi generator", "src=https://openapi-generator.tech", "protocol=uri"

class
	HTTP_BASIC_AUTH

inherit

	AUTHENTICATION

feature -- Access

	user_name: detachable STRING_32
			-- user name.

	password: detachable STRING_32
			-- password.

feature -- Element Change	

	set_user_name (a_name: STRING_32)
			-- Set `user_name' with `a_name'.
		do
			user_name := a_name
		ensure
			user_name_set: user_name = a_name
		end

	set_password (a_password: STRING_32)
			-- Set `password' with `a_password'.
		do
			password := a_password
		ensure
			password_set: password = a_password
		end

feature -- Access

	apply_to_params(a_query_params: LIST [TUPLE [name:STRING; value:STRING]]; a_header_params: STRING_TABLE [STRING])
   			-- <Precursor>.
		do
			if
				attached user_name as l_username and then
				attached password as l_password
			then
				a_header_params.force ("Basic " + (create {BASE64}).encoded_string (l_username + ":" + l_password) , "Authorization")
			end
   		end

end
