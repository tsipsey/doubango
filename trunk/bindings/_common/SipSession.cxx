/*
* Copyright (C) 2009 Mamadou Diop.
*
* Contact: Mamadou Diop <diopmamadou@doubango.org>
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
#include "SipSession.h"
#include "SipStack.h"

SipSession::SipSession(SipStack* _stack)
{
	this->handle = tsip_ssession_create(_stack->getHandle(),
		TSIP_SSESSION_SET_USERDATA(this),
		TSIP_SSESSION_SET_NULL());
	this->stack = _stack;
}

SipSession::~SipSession()
{
	tsip_ssession_set(this->handle,
		TSIP_SSESSION_SET_USERDATA(tsk_null),
		TSIP_SSESSION_SET_NULL());

	TSK_OBJECT_SAFE_FREE(this->handle);
}

bool SipSession::addHeader(const char* name, const char* value)
{
	int ret = tsip_ssession_set(this->handle,
		TSIP_SSESSION_SET_HEADER(name, value),
		TSIP_SSESSION_SET_NULL());
	return (ret == 0);
}

bool SipSession::removeHeader(const char* name)
{
	int ret = tsip_ssession_set(this->handle,
		TSIP_SSESSION_UNSET_HEADER(name),
		TSIP_SSESSION_SET_NULL());
	return (ret == 0);
}

bool SipSession::addCaps(const char* name, const char* value)
{
	int ret = tsip_ssession_set(this->handle,
		TSIP_SSESSION_SET_CAPS(name, value),
		TSIP_SSESSION_SET_NULL());
	return (ret == 0);
}

bool SipSession::addCaps(const char* name)
{
	int ret = tsip_ssession_set(this->handle,
		TSIP_SSESSION_SET_CAPS(name, tsk_null),
		TSIP_SSESSION_SET_NULL());
	return (ret == 0);
}

bool SipSession::removeCaps(const char* name)
{
	int ret = tsip_ssession_set(this->handle,
		TSIP_SSESSION_UNSET_CAPS(name),
		TSIP_SSESSION_SET_NULL());
	return (ret == 0);
}

bool SipSession::setExpires(unsigned expires)
{
	int ret = tsip_ssession_set(this->handle,
		TSIP_SSESSION_SET_EXPIRES(expires),
		TSIP_SSESSION_SET_NULL());
	return (ret == 0);
}

bool SipSession::setFromUri(const char* fromUri)
{
	int ret = tsip_ssession_set(this->handle,
		TSIP_SSESSION_SET_FROM(fromUri),
		TSIP_SSESSION_SET_NULL());
	return (ret == 0);
}

bool SipSession::setToUri(const char* toUri)
{
	int ret = tsip_ssession_set(this->handle,
		TSIP_SSESSION_SET_TO(toUri),
		TSIP_SSESSION_SET_NULL());
	return (ret == 0);
}

const SipStack* SipSession::getStack()const
{
	return this->stack;
}
