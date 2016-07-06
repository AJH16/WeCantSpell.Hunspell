﻿/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Hunspell, based on MySpell.
 *
 * The Initial Developers of the Original Code are
 * Kevin Hendricks (MySpell) and Németh László (Hunspell).
 * Portions created by the Initial Developers are Copyright (C) 2002-2005
 * the Initial Developers. All Rights Reserved.
 *
 * Contributor(s): David Einstein, Davide Prina, Giuseppe Modugno,
 * Gianluca Turconi, Simon Brouwer, Noll János, Bíró Árpád,
 * Goldman Eleonóra, Sarlós Tamás, Bencsáth Boldizsár, Halácsy Péter,
 * Dvornik László, Gefferth András, Nagy Viktor, Varga Dániel, Chris Halls,
 * Rene Engelhard, Bram Moolenaar, Dafydd Jones, Harri Pitkänen
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 *
 * ***** END LICENSE BLOCK ***** */
/*
 * Copyright 2002 Kevin B. Hendricks, Stratford, Ontario, Canada
 * And Contributors.  All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 *
 * 1. Redistributions of source code must retain the above copyright
 *    notice, this list of conditions and the following disclaimer.
 *
 * 2. Redistributions in binary form must reproduce the above copyright
 *    notice, this list of conditions and the following disclaimer in the
 *    documentation and/or other materials provided with the distribution.
 *
 * 3. All modifications to the source code must be clearly marked as
 *    such.  Binary redistributions based on modified source code
 *    must be clearly marked as modified versions in the documentation
 *    and/or other materials provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY KEVIN B. HENDRICKS AND CONTRIBUTORS
 * ``AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
 * LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS
 * FOR A PARTICULAR PURPOSE ARE DISCLAIMED.  IN NO EVENT SHALL
 * KEVIN B. HENDRICKS OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
 * LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
 * OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
 * SUCH DAMAGE.
 */

/*
 *
 * This is a modified version of the Hunspell source code for the
 * purpose of creating an idiomatic port.
 *
 */

using Hunspell.Utilities;
using System;

using Flag = System.UInt16;

namespace Hunspell
{
    /// <summary>
    /// A prefix entry.
    /// </summary>
    public class PfxEntry : AffEntry
    {
        public PfxEntry(AffixMgr pmgr)
        {
            PmyMgr = pmgr;
        }

        private AffixMgr PmyMgr { get; set; }

        public PfxEntry Next { get; set; }

        public PfxEntry NextEq { get; set; }

        public PfxEntry NextNe { get; set; }

        public PfxEntry FlgNxt { get; set; }

        public bool AllowCross
        {
            get
            {
                return (Opts & ATypes.AeXProduct) != 0;
            }
        }

        public Flag Flag
        {
            get
            {
                return checked((Flag)AFlag);
            }
        }

        public string Key
        {
            get
            {
                return Appnd;
            }
        }

        public short KeyLen
        {
            get
            {
                return checked((short)Key.Length);
            }
        }

        public ushort[] Cont
        {
            get
            {
                return ContClass;
            }
        }

        public string Morph
        {
            get
            {
                return MorphCode;
            }
        }

        public short ContLen
        {
            get
            {
                return ContClassLen;
            }
        }

        [CLSCompliant(false)]
        public HEntry CheckWord(sbyte[] word, int len, sbyte in_compound, Flag needFlag = default(Flag))
        {
            throw new NotImplementedException();
        }

        [CLSCompliant(false)]
        public HEntry CheckTwoSfx(sbyte[] word, int len, sbyte in_compound, Flag needFlag = default(Flag))
        {
            throw new NotImplementedException();
        }

        [CLSCompliant(false)]
        public sbyte[] CheckMorph(sbyte[] word, int len, sbyte in_compound, Flag needFlag = default(Flag))
        {
            throw new NotImplementedException();
        }

        [CLSCompliant(false)]
        public sbyte[] CheckTwoSfxMorph(sbyte[] word, int len, sbyte in_compound, Flag needFlag = default(Flag))
        {
            throw new NotImplementedException();
        }

        [CLSCompliant(false)]
        public sbyte[] Add(sbyte[] word, uint len)
        {
            throw new NotImplementedException();
        }

        public sbyte[] NextChar(sbyte[] p)
        {
            throw new NotImplementedException();
        }

        public int TestCondition(sbyte[] st)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// A suffix entry.
    /// </summary>
    public class SfxEntry : AffEntry
    {
        public SfxEntry(AffixMgr pmgr)
        {
            PmyMgr = pmgr;
        }

        private AffixMgr PmyMgr { get; set; }

        private string RAppnd { get; set; }

        public SfxEntry Next { get; set; }

        public SfxEntry NextEq { get; set; }

        public SfxEntry NextNe { get; set; }

        public SfxEntry FlgNxt { get; set; }

        public SfxEntry LMorph { get; }

        public SfxEntry RMorph { get; }

        public SfxEntry EqMorph { get; }

        bool AllowCross
        {
            get
            {
                return (Opts & ATypes.AeXProduct) != 0;
            }
        }

        public Flag Flag
        {
            get
            {
                return checked((Flag)AFlag);
            }
        }

        public string Key
        {
            get
            {
                return RAppnd;
            }
        }

        public short KeyLen
        {
            get
            {
                return checked((short)Appnd.Length);
            }
        }

        public string Morph
        {
            get
            {
                return MorphCode;
            }
        }

        [CLSCompliant(false)]
        public ushort[] Cont
        {
            get
            {
                return ContClass;
            }
        }

        public short ContLen
        {
            get
            {
                return ContClassLen;
            }
        }

        public string Affix
        {
            get
            {
                return Appnd;
            }
        }



        [CLSCompliant(false)]
        public HEntry CheckWord(sbyte[] word, int len, int optFlags, PfxEntry ppfx, Flag cclass, Flag needFlag, Flag badFlag)
        {
            throw new NotImplementedException();
        }

        [CLSCompliant(false)]
        public HEntry CheckTwoSfx(sbyte[] word, int len, int optFlags, PfxEntry ppfx, Flag needFlag = default(Flag))
        {
            throw new NotImplementedException();
        }

        [CLSCompliant(false)]
        public sbyte[] CheckTwoSfxMorph(sbyte[] word, int len, int optFlags, PfxEntry ppfx, Flag needFlag = default(Flag))
        {
            throw new NotImplementedException();
        }

        HEntry GetNextHomonym(HEntry he)
        {
            throw new NotImplementedException();
        }

        HEntry GetNextHomonym(HEntry word, int optFlags, PfxEntry ppfx, Flag cclass, Flag needFlag)
        {
            throw new NotImplementedException();
        }

        [CLSCompliant(false)]
        public sbyte[] Add(sbyte[] word, uint len)
        {
            throw new NotImplementedException();
        }

        public void InitReverseWord()
        {
            RAppnd = Appnd;
            RAppnd = RAppnd.Reverse();
        }

        [CLSCompliant(false)]
        public sbyte[] NextChar(sbyte[] p)
        {
            throw new NotImplementedException();
        }

        [CLSCompliant(false)]
        public int TestCondition(sbyte[] st, sbyte[] begin)
        {
            throw new NotImplementedException();
        }
    }
}