/*
 * Keepa API
 *
 * The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
 *
 * API version: 1.0.0
 * Contact: info@keepa.com
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package openapi

import (
	"net/http"

	"github.com/gin-gonic/gin"
)

// Product - Retrieve the product for the specified ASIN and domain.
func Product(c *gin.Context) {
	c.JSON(http.StatusOK, gin.H{})
}
