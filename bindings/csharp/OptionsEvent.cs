/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class OptionsEvent : SipEvent {
  private HandleRef swigCPtr;

  internal OptionsEvent(IntPtr cPtr, bool cMemoryOwn) : base(tinyWRAPPINVOKE.OptionsEventUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(OptionsEvent obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~OptionsEvent() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPPINVOKE.delete_OptionsEvent(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public tsip_options_event_type_t getType() {
    tsip_options_event_type_t ret = (tsip_options_event_type_t)tinyWRAPPINVOKE.OptionsEvent_getType(swigCPtr);
    return ret;
  }

  public OptionsSession getSession() {
    IntPtr cPtr = tinyWRAPPINVOKE.OptionsEvent_getSession(swigCPtr);
    OptionsSession ret = (cPtr == IntPtr.Zero) ? null : new OptionsSession(cPtr, false);
    return ret;
  }

}

}
