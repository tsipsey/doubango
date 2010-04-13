/*
* Copyright (C) 2009 Mamadou Diop.
*
* Contact: Mamadou Diop <diopmamadou(at)doubango.org>
*	
* This file is part of Open Source Doubango Framework.
*
* DOUBANGO is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*	
* DOUBANGO is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*	
* You should have received a copy of the GNU General Public License
* along with DOUBANGO.
*
*/

/**@file tsms_tpdu_submit.h
 * @brief SMS TPDU SMS-SUBMIT (MO) message as per 3GPP TS 23.040 section 9.2.2.2.
 *
 * @author Mamadou Diop <diopmamadou(at)doubango.org>
 *
 * @date Created: Sat Nov 8 16:54:58 2009 mdiop
 */
#ifndef TINYSMS_TSMS_TPDU_SUBMIT_H
#define TINYSMS_TSMS_TPDU_SUBMIT_H

#include "tinysms_config.h"

#include "tinySMS/tsms_common.h"

TSMS_BEGIN_DECLS


/** SMS TPDU SMS-SUBMIT message as per 3GPP TS 23.040 section 9.2.2.2
*/
typedef struct tsms_tpdu_submit_s
{
	TSMS_DECLARE_TPDU_MESSAGE;

	tsms_address_t* smsc;

	/** TP Reject Duplicates (M - 1b)
	* Parameter indicating whether or not the SC shall accept an SMS SUBMIT for an 
	* SM still held in the SC which has the same TP MR and the same TP DA as a 
	* previously submitted SM from the same OA. */
	unsigned rd:1;
	/** TP Validity Period Format (M - 2b)
	* Parameter indicating whether or not the TP VP field is present. */
	tsms_tpdu_vpf_t vpf;
	/** TP Reply Path (M - 1b)
	* Parameter indicating the request for Reply Path. */
	unsigned rp:1;
	/** TP User Data Header Indicator (O - 1b)
	* Parameter indicating that the TP UD field contains a Header. */
	unsigned udhi:1;
	/** TP Status Report Request (O - 1b)
	* Parameter indicating if the MS is requesting a status report. */
	unsigned srr:1;
	/** TP Message Reference (M - I)
	* Parameter identifying the SMS SUBMIT. */
	uint8_t mr;
	/** TP Destination Address (M - 2-12o)
	* Address of the destination SME. */
	tsms_address_t* da;
	/** TP Protocol Identifier (M - o)
	* Parameter identifying the above layer protocol, if any. */
	//(base)uint8_t pid;
	/** TP Data Coding Scheme (M - o)
	* Parameter identifying the coding scheme within the TP User Data. */
	//(base)uint8_t dcs;
	/** TP Validity Period (O - o/7o)
	* Parameter identifying the time from where the message is no longer valid. */
	uint8_t vp[7];
	/** TP User Data Length (M - I)
	* Parameter indicating the length of the TP User Data field to follow. */
	//(base)uint8_t udl;
	/** TP User Data (O - v)
	* User data. */
	//(base)tsk_buffer_t* ud;
}
tsms_tpdu_submit_t;

typedef void tsms_tpdu_submit_handle_t;

TINYSMS_API tsms_tpdu_submit_handle_t* tsms_tpdu_submit_create(uint8_t mr, tsms_address_string_t smsc, tsms_address_string_t dest);

#define tsms_tpdu_submit_serialize(self, output) tsms_tpdu_message_serialize(TSMS_TPDU_MESSAGE(self), output, tsk_true)
#define tsms_tpdu_submit_tostring(self) tsms_tpdu_message_tostring(TSMS_TPDU_MESSAGE(self), tsk_true)
#define tsms_tpdu_submit_tohexastring(self) tsms_tpdu_message_tohexastring(TSMS_TPDU_MESSAGE(self), tsk_true)
#define tsms_tpdu_submit_set_userdata(self, udata, alpha) tsms_tpdu_message_set_userdata(TSMS_TPDU_MESSAGE(self), udata, alpha)

TINYSMS_GEXTERN const tsk_object_def_t *tsms_tpdu_submit_def_t;

TSMS_END_DECLS

#endif /* TINYSMS_TSMS_TPDU_SUBMIT_H */