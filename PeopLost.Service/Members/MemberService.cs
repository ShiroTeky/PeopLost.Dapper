
using System;
using System.Collections.Generic;
using PeopLost.Core.Data;
using PeopLost.Core.Domain.Members;
using PeopLost.Core.Domain.Pictures;


namespace PeopLost.Service.Members
{
    public virtual class MemberService: IMemberService
    {
        IRepository<Member> memberRepository;
        IRepository<Picture> pictureRepository;

        public MemberService(IRepository<Member> memberRepository, IRepository<Picture> pictureRepository)
        {
            this.memberRepository = memberRepository;
            this.pictureRepository = pictureRepository;
        }

        public virtual void DeleteMember(Member member)
        {
            memberRepository.Delete(member);
            pictureRepository.Delete(member.PictureAdmin);
        }

        public virtual Member GetMemberById(int memberId)
        {
            return memberRepository.GetById(memberId);
        }

        public virtual void InsertMember(Member member)
        {
            memberRepository.Insert(member);
        }

        public virtual void UpdateMember(Member member)
        {
            memberRepository.Update(member);
        }
    }
}
